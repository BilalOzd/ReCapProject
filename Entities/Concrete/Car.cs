using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; } //colorid 1= beyaz, 2 = siyah, 3 = mavi
        public int ModelYear { get; set; }
        public long DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
