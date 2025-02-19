using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; } = "";
        public string? Breed { get; set; } = "";
        public string? Species { get; set; } = "";
        public int Age { get; set; }
        public int OwnerId { get; set; }
        public Owner? Owner { get; set; }
    }
}
