using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iot_Project.Models
{
    public class Room
    {
        private int zlevel;
        private string accessLeve;
        private string venueId;
        private string venueName;
        private string roomId;

        public Room(int zlevel, string accessLeve, string venueId, string venueName, string roomId)
        {
            this.zlevel = zlevel;
            this.accessLeve = accessLeve;
            this.venueId = venueId;
            this.venueName = venueName;
            this.roomId = roomId;
        }

        public int Zlevel { get => zlevel; set => zlevel = value; }
        public string AccessLeve { get => accessLeve; set => accessLeve = value; }
        public string VenueId { get => venueId; set => venueId = value; }
        public string VenueName { get => venueName; set => venueName = value; }
        public string RoomId { get => roomId; set => roomId = value; }

        public string ToString()
        {
            return Zlevel + " " + AccessLeve + " " + VenueId + " " + VenueName + " " + RoomId;
        }
    }

}
