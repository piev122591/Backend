

namespace Maestro.Infrastructure.Configuration
{
    public static class ConfigurationConstants
    {
        /// <summary>
        /// Name of the connection string
        /// </summary>
        public const string DefaultConnection = nameof(ConfigurationConstants.DefaultConnection);

        /// <summary>
        /// Connection string section
        /// </summary>
        public const string ConnectionStrings = nameof(ConfigurationConstants.ConnectionStrings);
        /// <summary>
        /// Database in connection string
        /// </summary>
        public const string Database = nameof(ConfigurationConstants.Database);
        /// <summary>
        /// Tenant id key
        /// </summary>
        public const string TenantId = "TenantId";

        /// <summary>
        /// API id key
        /// </summary>
        public const string APIKey = "APIKey";
    }
}
