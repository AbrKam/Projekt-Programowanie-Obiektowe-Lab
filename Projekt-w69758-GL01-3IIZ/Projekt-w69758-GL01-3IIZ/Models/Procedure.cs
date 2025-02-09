using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.Models
{
    internal class Procedure
    {
        public int Id { get; set; }
        public string? Purpose { get; set; } = "";
        public string? Description { get; set; } = "";
        public int TimeTaken { get; set; }
        public decimal? Cost { get; set; } = null;
    }
}
