using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.Models
{
    internal class Owner
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } = "";
        public string? LastName { get; set; } = "";
        public string? TelephoneNumber { get; set; } = "";
        public string? Email { get; set; } = "";
        public List<Animal>? Animals { get; set; }
    }
}
