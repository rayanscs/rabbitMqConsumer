﻿namespace TPL.RabbitMQ.Consumer.Domain.Models.Mensageria
{
    public class Mensagem
    {
        public Mensagem()
        {
            Header = new Header();
            Body = new { };
        }

        public Header Header { get; set; }
        public dynamic Body { get; set; }
    }

    public class Header
    {
        public DateTime DataEntradaFila { get; set; }
        public string ProjetoOrigem { get; set; } = string.Empty;
        public string FilaOrigem { get; set; } = string.Empty;
    }
}
