using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    public class MenuModel
    {
        [Key]
        public int id { get; set; }
        public string buttonName { get; set; }
        public string categories { get; set; }



        public MenuModel()
        {

        }
    }
}