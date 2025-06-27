using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTracker.Models
{
    internal class StudySession
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? Topic { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Notes { get; set; }

        public TimeSpan Duration => EndTime - StartTime;
    }
}
