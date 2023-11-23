using BLL;
using DAL.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceRoom sRoom = new ServiceRoom();


            //Room room = new Room();
            //room.Avaliable = true;
            //room.Floor = 1;
            //room.Price = 5000;
            //room.TypeRoom = 1;//1-Standart
            //room.CountRoom = 1;


            //string resul = sRoom.CreateRoom(room);
            //Console.WriteLine(resul);

            ServiceRoomReserve reserve = 
                new ServiceRoomReserve();


           string result =  reserve.ReserveRoom(1, DateTime.Now.AddDays(2), DateTime.Now.AddDays(5));

            Console.WriteLine(result);
        }
    }
}
