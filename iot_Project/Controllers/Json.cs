using iot_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Project.Controllers
{
    public class Json
    {

        public List<string> LoadJson()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Bjørn\\Documents\\GIT\\IoT\\ou44_geometry.geojson.txt");
            string content = file.ReadToEnd();
            file.Close();

            dynamic deserialized = JsonConvert.DeserializeObject(content);
            List<Room> lstRooms = new List<Room>();
            foreach (var item in deserialized.features)
            {
                if(item.properties.Class == "Room" && item.properties.RoomId!=null)
                {
                    string roomId = item.properties.RoomId;
                    int zLevel = item.properties.ZLevel;
                    string accessLevel = item.properties.AccessLeve;
                    string venueId = item.properties.VenueId;
                    string venueName = item.properties.VenueName;
                    lstRooms.Add(new Room(zLevel, accessLevel, venueId, venueName, roomId));


                }
              
            }
            List<string> rooms = new List<string>();
            foreach(Room room in lstRooms)
            {
                rooms.Add(room.ToString());
            }
            return rooms;

        }
    }
}
