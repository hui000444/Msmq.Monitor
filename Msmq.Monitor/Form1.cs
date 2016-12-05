using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Msmq.Monitor
{
    public partial class FormMsmqMonitor : Form
    {
        private readonly int interval;
        private int intervalTemp;
        private const int IntervalUnit = 1000;
        private readonly string queueName = ConfigurationManager.AppSettings["QueueName"];


        public FormMsmqMonitor()
        {
            InitializeComponent();

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            timerQueryMsmq.Enabled = true;
            interval = intervalTemp = Convert.ToInt32(ConfigurationManager.AppSettings["SecondSpan"]);
            timerQueryMsmq.Interval = IntervalUnit;
            textBoxInterval.Text = (intervalTemp / IntervalUnit).ToString();
            timerQueryMsmq.Start();
        }

        private void Form_Msmq_Monitor_Load(object sender, EventArgs e)
        {
            BindingMessageQueueDataSource();
        }

        private void BindingMessageQueueDataSource()
        {
            var myQueue = new MessageQueue(queueName)
            {
                Formatter = new XmlMessageFormatter(new[] { typeof(string) }),
            };
            using (myQueue)
            {
                if (myQueue.CanRead)
                {
                    var result = new List<QueueMessage>();
                    var count = 0;
                    var enumerator = myQueue.GetMessageEnumerator2();
                    while (enumerator.MoveNext())
                    {
                        count++;
                        var message = enumerator.Current;
                        QueueMessage queueMessage;
                        try
                        {
                            queueMessage = JsonConvert.DeserializeObject<QueueMessage>((string)message.Body);
                            if (queueMessage.QueueMetadata == null)
                                queueMessage.QueueMetadata = new QueueMetadata();
                        }
                        catch (Exception)
                        {
                            queueMessage = new QueueMessage { Data = (string)message.Body, QueueMetadata = new QueueMetadata() };
                        }
                        result.Add(queueMessage);
                    }
                    var dataSource = result.Select(
                        d => new
                        {
                            d.QueueMetadata.EventType,
                            d.QueueMetadata.AggregateType,
                            d.QueueMetadata.Guid,
                            d.QueueMetadata.ModifierApplicationTypeName,
                            d.QueueMetadata.ModifierId,
                            d.QueueMetadata.ShortEventType,
                            d.QueueMetadata.StreamName,
                            EventBody = d.Data
                        }).ToList();

                    dataGridView1.DataSource = dataSource;
                    textBoxCount.Text = count.ToString();
                }
                else
                {
                    try
                    {
                        //if no messgae, used Received Method will throw exception
                        myQueue.GetAllMessages();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        timerQueryMsmq.Stop();
                    }
                }
            }
        }

        private void dataGridViewMsmq_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView1.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void timerQueryMsmq_Tick(object sender, EventArgs e)
        {
            intervalTemp -= IntervalUnit;
            textBoxInterval.Text = (intervalTemp / IntervalUnit).ToString();
            if (intervalTemp != 0) return;
            
            timerQueryMsmq.Stop();
            intervalTemp = interval;
            textBoxInterval.Text = (intervalTemp / IntervalUnit).ToString();
            BindingMessageQueueDataSource();
            timerQueryMsmq.Start();
        }


        private void delete_top1_button_Click(object sender, EventArgs e)
        {
            var myQueue = new MessageQueue(queueName)
            {
                Formatter = new XmlMessageFormatter(new[] { typeof(string) }),
            };
            using (myQueue)
            {
                myQueue.Receive();
            }
        }
    }

}
