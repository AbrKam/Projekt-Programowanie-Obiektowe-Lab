using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.Models
{
    internal class Visit
    {
        public int Id { get; set; }
        public string? Purpose { get; set; } = "";
        public string? Description { get; set; } = "";
        public DateTime Data {  get; set; }
        public int VetId { get; set; }
        public int AnimalId { get; set; }
    }
}
