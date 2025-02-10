using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.Models
{
    internal class VisitsProcedures
    {
        public int Id {  get; set; }
        public int VisitId {  get; set; }
        public Visit? Visit {  get; set; }
        public int ProcedureId { get; set; }
        public Procedure? Procedure { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
