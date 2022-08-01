using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{

    
        public class Bozainik
        {

        public Bozainik(string name)
            {
                Name = name;
                /*Information = information;
                Photo = photo;*/
            }

            public string Name { get; set; }
            public string Information { get; set; }
            public byte Photo { get; set; }
        }
    
}



