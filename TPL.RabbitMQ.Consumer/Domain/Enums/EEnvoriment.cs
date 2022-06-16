using System.ComponentModel;

namespace TPL.RabbitMQ.Consumer.Domain.Enums
{
    public enum EEnvoriment
    {
        [Description("stg")]
        Staging,
        [Description("prd")]
        Production
    }
}
