namespace TPL.RabbitMQ.Consumer.Domain.Interfaces.RabbitMq
{
    public interface IMessageBus
    {
        void Start();
        void Stop();
        void Subscribe(CancellationToken cancellationToken);
    }
}
