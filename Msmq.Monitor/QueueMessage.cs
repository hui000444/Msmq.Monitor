namespace Msmq.Monitor
{
    public class QueueMessage
    {
        public object Data { get; set; }

        public QueueMetadata QueueMetadata { get; set; }
    }


    public class QueueMetadata
    {
        public string EventType { get; set; }
        public string ShortEventType { get; set; }
        public string AggregateType { get; set; }
        public string ModifierId { get; set; }
        public string Guid { get; set; }
        public string ModifierApplicationTypeName { get; set; }
        public string StreamName { get; set; }
    }
}