using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsHW
{
    public class Car
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public Person Owner { get; set; }
    }
}
