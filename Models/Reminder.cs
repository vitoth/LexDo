using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexDo.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Time)]
        public DateTime CreateTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime FinishedTime { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
