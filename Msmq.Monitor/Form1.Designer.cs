namespace Msmq.Monitor
{
    partial class FormMsmqMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxMsmq = new System.Windows.Forms.GroupBox();
            this.delete_top1_button = new System.Windows.Forms.Button();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerQueryMsmq = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxMsmq.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(826, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewMsmq_RowPostPaint);
            // 
            // groupBoxMsmq
            // 
            this.groupBoxMsmq.Controls.Add(this.delete_top1_button);
            this.groupBoxMsmq.Controls.Add(this.textBoxInterval);
            this.groupBoxMsmq.Controls.Add(this.label2);
            this.groupBoxMsmq.Controls.Add(this.textBoxCount);
            this.groupBoxMsmq.Controls.Add(this.label1);
            this.groupBoxMsmq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMsmq.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMsmq.Name = "groupBoxMsmq";
            this.groupBoxMsmq.Size = new System.Drawing.Size(826, 42);
            this.groupBoxMsmq.TabIndex = 1;
            this.groupBoxMsmq.TabStop = false;
            this.groupBoxMsmq.Text = "Summary Information";
            // 
            // delete_top1_button
            // 
            this.delete_top1_button.Location = new System.Drawing.Point(704, 11);
            this.delete_top1_button.Name = "delete_top1_button";
            this.delete_top1_button.Size = new System.Drawing.Size(95, 23);
            this.delete_top1_button.TabIndex = 4;
            this.delete_top1_button.Text = "!!! Delete Top 1";
            this.delete_top1_button.UseVisualStyleBackColor = true;
            this.delete_top1_button.Click += new System.EventHandler(this.delete_top1_button_Click);
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(471, 12);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.ReadOnly = true;
            this.textBoxInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterval.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time to Resfresh:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(230, 16);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.ReadOnly = true;
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 1;
            this.textBoxCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Count:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxMsmq, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53881F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 465);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // timerQueryMsmq
            // 
            this.timerQueryMsmq.Interval = 50;
            this.timerQueryMsmq.Tick += new System.EventHandler(this.timerQueryMsmq_Tick);
            // 
            // FormMsmqMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 465);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMsmqMonitor";
            this.Text = "Microsoft Message Queue Monitor";
            this.Load += new System.EventHandler(this.Form_Msmq_Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxMsmq.ResumeLayout(false);
            this.groupBoxMsmq.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxMsmq;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timerQueryMsmq;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_top1_button;
    }
}

