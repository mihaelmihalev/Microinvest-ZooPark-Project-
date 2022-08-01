using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    public class Category
    {
        
            public Category( string name)
            {
                Name = name;
                
            }

            public string Name { get; set; }
            public string Id { get; set; }
        }
    }