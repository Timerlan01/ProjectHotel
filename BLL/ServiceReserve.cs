using Astana.DAL;
using DAL.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceRoomReserve
    {
        /// <summary>
        /// Проверку на доступность по ID комнаты
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RoomIsAvaliable(int id)
        {
            Repositories<Room> db = new Repositories<Room>();
            var list = db.GetAll();
            var room = list.FirstOrDefault(f => f.Id == id);

            return room.Avaliable;
        }

        /// <summary>
        /// Метод кторый возвращает доступностькомнаты по датам
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public bool RoomIsAvaliable(int id, DateTime startDate, DateTime endDate)
        {
            Repositories<Reserve> db = new Repositories<Reserve>();
            var list = db.GetAll();
            var room = list
                .Where(f => f.Id == id &&
                (startDate >= f.StartDate && endDate <= f.EndDate));

            if (room.Count() > 0)
                return true;
            else
                return false;

            //return room.Count() > 0;
            //return room.Count() >0 ? true : false;
        }

        //РезервКомнта
        public string ReserveRoom(int id, DateTime startDate, DateTime endDate)
        {
            Repositories<Reserve> db = new Repositories<Reserve>();

            Reserve reserve = new Reserve();
            reserve.CreateDate = DateTime.Now;
            reserve.RoomId = id;
            reserve.StartDate = startDate;
            reserve.EndDate = endDate;

            if (!RoomIsAvaliable(id, startDate, endDate))
                return "Комната на текущие даты занята";

            if (db.Create(reserve))
            {
                return "Бронь успешно произведена";
            }
            else
            {
                return "При бронировании возникла ошибка";
            }
        }
    }
}