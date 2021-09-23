using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Pasteleria.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public short Active { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }

    }

}
