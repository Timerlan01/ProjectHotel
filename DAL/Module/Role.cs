using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Module
{
    class Role
    {
        public int Id { get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public DateTime EndDate { get; set; }
        public List<Role> Roles { get; set; }
    }
}

