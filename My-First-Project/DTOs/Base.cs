using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_Project.DTOs
{
    public class Base:Students
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
    
       
}
