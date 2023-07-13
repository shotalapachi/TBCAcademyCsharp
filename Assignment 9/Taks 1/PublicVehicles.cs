using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taks_1;

namespace Taks_1
{
    internal interface IPublicVehicles
    {
        int _seatCount { get; }
        bool _hasAC { get; }
        Public _type { get; }

        void OpenDoor();
    }

    internal class PublicVehicle : Vehicle, IPublicVehicles
    {
        public PublicVehicle(string name, string description, Vehicles category, int topSpeed, int distanceTraveled, int seatCount, bool hasAC, Public type)
            : base(name, description, category, topSpeed, distanceTraveled)
        {
            _seatCount = seatCount;
            _hasAC = hasAC;
            _type = type;
        }

        public int _seatCount { get; }
        public bool _hasAC { get; }
        public Public _type { get; }

        public override void Start()
        {
            Console.WriteLine("Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public void OpenDoor()
        {
            Console.WriteLine("Door opened");
        }
    }

}   