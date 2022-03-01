using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public enum Gender { Male = 1, Female = 2, Unspecified = 3 }
        public string Gender { get; set; }
    }
}
