using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.Models
{
    internal class Payment
    {
        public int Id { get; set; }
        public int VisitId {  get; set; }
        public Visit? Visit {  get; set; }
        public string? PaymentMethod { get; set; } = "";
        public decimal? Cost { get; set; } = null;
        public DateTime? Date { get; set; } = null;
        public bool Invoice { get; set; } = false;
    }
}
