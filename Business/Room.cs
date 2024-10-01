using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2010s_semesterProject.Business
{
    public class Room
    {
        #region Fields
        private string roomID;
        private double roomPrice;
        private int roomCapacity;
        private RoomStatus roomStatus;

        public enum RoomStatus
        {
            Available,
            Reserved,
            Occupied
        }
        #endregion

        #region Properties
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public double RoomPrice
        {
            get { return roomPrice; }
            set { roomPrice = value; }
        }
        public int RoomCapacity
        {
            get { return roomCapacity; }
            set { roomCapacity = value; }
        }

        public RoomStatus Status
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }
        #endregion

        #region Constructor
        public Room()
        {
            roomID = "";
            roomPrice = 0;
            roomCapacity = 0;
            roomStatus = RoomStatus.Available;
        }
        public Room(string RoomID, double RoomPrice, int roomCapacity, RoomStatus roomStatus)
        {
            this.roomID = RoomID;
            this.roomPrice = RoomPrice;
            this.roomCapacity = roomCapacity;
            roomStatus = RoomStatus.Available;
        }

        #endregion
    }
}
