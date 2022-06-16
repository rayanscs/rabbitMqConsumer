namespace TPL.RabbitMQ.Consumer.Domain.Entities
{
    public class EntidadeDTO
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
