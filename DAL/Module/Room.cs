using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Module
{
    class Room
    {
        public int Id { get; set; }
        public DateTime CreatDate { get; set; }
        public int CountRoom { get; set; }
        public int Floor { get; set; }
        public int TypeRoom { get; set; }
        public double Price { get; set; }
        public List<RoomProperty> RoomProperties { get; set; }
        public List<Ferniture> Fernituries { get; set; }
        public List <Reserve> Reserves { get; set; }    
    }
}
