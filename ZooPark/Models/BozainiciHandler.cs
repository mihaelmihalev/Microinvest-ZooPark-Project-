using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Models
{
    public class BozainiciHandler
    {
        public BozainiciHandler()
        {
           Bozainici = new List<Bozainik>();
        }

        public List<Bozainik> Bozainici { get; private set; }

        public void Add(Bozainik bozainik)
        {
            Bozainici.Add(bozainik);
        }
    }
}
    
