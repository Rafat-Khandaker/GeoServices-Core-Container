using GeoServices_Core_Commons.Models;
using GeoServices_Core_Commons.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Entity.Contracts
{
    public interface IDatabaseContext<Y>
    {
        public Y Database { get; set; }
        public SQLType Type { get; set; }

        public DatabaseContext AddConnection(string connectionString);
        public Y Build(string connect);

    }
}
