using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWuld.Models
{
    class AlbumSale
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public int SaleId { get; set; }

        public AlbumSale(int id, int albumId, int saleId)
        {
            Id = id;
            AlbumId = albumId;
            SaleId = saleId;
        }
    }
}
