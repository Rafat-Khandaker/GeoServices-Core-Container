using GeoServices_Core_Commons.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Entity.Contracts
{
    public interface IAppDatabase
    {
        public DbSet<PerformanceLog> PerformanceLogs { get; set; }

        public string ConnectionString { get; set; }
        public AppDatabase DetachEntities();
        public void Attach_And_Save_Entities(List<PerformanceLog> newEntities);
    }
}
