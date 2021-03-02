using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; } //colorid 10 = beyaz, 11 = siyah, 12 = mavi
        public int ModelYear { get; set; }
        public long DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
