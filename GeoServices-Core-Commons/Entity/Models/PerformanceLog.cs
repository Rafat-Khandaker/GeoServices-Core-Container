
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoServices_Core_Commons.Entity.Models
{
    public class PerformanceLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Mutex { get; set; }
        public int Wait { get; set; }
        public int Max { get; set; }
        public int Sleep { get; set; }
        public int Retry { get; set; }
        public double Pass { get; set; }
        public double Fail { get; set; }
        public double CallsPerSecond { get; set; }
        public double CallsPerHour { get; set; }
        public DateTime? DateTime { get; set; }
        public string? RequestMessage { get; set; }
    }
}
