
using System.Data;


namespace Maestro.Infrastructure.Contracts
{
    public interface IConnectionFactory
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        IDbConnection Connection { get; }
    }
}
