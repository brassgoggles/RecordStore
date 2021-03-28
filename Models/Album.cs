using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWuld
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal? Price { get; set; }

        public Album(int id, string name,
            DateTime releaseDate, decimal? price)
        {
            Id = id;
            Name = name;
            ReleaseDate = releaseDate;
            Price = price;
        }
    }
}
