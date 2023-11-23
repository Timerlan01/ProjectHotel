using Astana.DAL;
using DAL.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiceRoom : Service<Room>
    {
        public ServiceRoom():base()
        {}

        /// <summary>
        /// Создание комнаты
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public string CreateRoom(Room room)
        {
            if(db.Create(room))
            {
                return "Комната успешно добавлена";
            }
            else
            {
                return "При добавлении комнаты возникла ошибка";
            }
        }

        /// <summary>
        /// Рекдактирование 
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public string EditRoom(Room room)
        {
            if(db.Update(room))
            {
                return "Обновление прошло успешно";
            }
            else
            {
                return "При обновлении комнаты возникла ошибка";
            }
        }
    }
}
