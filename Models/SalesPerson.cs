using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWuld.Models
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SalesPerson(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
