using GeoServices_Core_Commons.Models;
using GeoServices_Core_Commons.Entity.Contracts;
using GeoServices_Core_Commons.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace GeoServices_Core_Commons.Entity
{
    public class DatabaseContext : IDatabaseContext<AppDatabase>, IDisposable
    {
        public AppDatabase Database { get; set; }
        public SQLType Type { get; set; }

        public string ConnectionString { get; set; }

        string DefaultConnection = "Data Source=localdb.db";
        private bool _disposed = false;


        public DatabaseContext AddConnection(string connectionString)
        {
            ConnectionString = connectionString;
            return this;
        }
        public AppDatabase Build(string connect = null) => BuildDatabase(connect);

        public AppDatabase Detach() => Database.DetachEntities();


        private AppDatabase BuildDatabase(string connection = null)
        {
            if (Database == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDatabase>();
                if (!string.IsNullOrEmpty(connection ?? ConnectionString))
                {
                    optionsBuilder.EnableSensitiveDataLogging().UseSqlServer(connection ?? ConnectionString);
                    Type = SQLType.Microsoft;
                }
                else
                {
                    optionsBuilder.EnableSensitiveDataLogging().UseSqlite(DefaultConnection);
                    Type = SQLType.SQLite;
                }
                Database = new AppDatabase(optionsBuilder.Options);
            }

            Database.Database.EnsureCreated();
            return Database;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                Database?.Dispose();
            }

            _disposed = true;
        }

    }
}
