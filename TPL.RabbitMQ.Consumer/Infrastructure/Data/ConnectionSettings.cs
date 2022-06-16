using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace TPL.RabbitMQ.Consumer.Infrastructure.Data
{
    public class ConnectionSettings
    {
        public IDbConnection DbOracleConnection => new OracleConnection(OracleConnection);
        public string OracleConnection { get; set; }
    }
}
