using System.Data;

namespace TPL.RabbitMQ.Consumer.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository
    {
        protected IDbTransaction Transection;
        protected IDbConnection Connection { get; }

        public virtual string QuerySelect { get; set; }
        public virtual string QuerySelectAll { get; set; }
        public virtual string QueryInsert { get; set; }
        public virtual string QueryUpdate { get; set; }
        public virtual string QueryDelete { get; set; }

        public BaseRepository(IDbConnection connection)
        {
            Connection = connection;
        }
    }
}
