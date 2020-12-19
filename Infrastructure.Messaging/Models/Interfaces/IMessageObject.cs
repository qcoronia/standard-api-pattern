namespace Infrastructure.Messaging.Models.Interfaces
{
    public interface IMessageObject
    {
        public object Raw { get; set; }
        public string Message { get; set; }
    }
}
