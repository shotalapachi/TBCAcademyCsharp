using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_1
{
    internal interface ISportVehicles
    {
        int _acceleration { get; }
        bool _isStreetLegal { get; }
        Sport _type { get; }

        void Race();
    }

    internal class SportVehicle : Vehicle, ISportVehicles
    {
        public SportVehicle(string name, string description, Vehicles category, int topSpeed, int distanceTraveled, int acceleration, bool isStreetLegal, Sport type)
            : base(name, description, category, topSpeed, distanceTraveled)
        {
            _acceleration = acceleration;
            _isStreetLegal = isStreetLegal;
            _type = type;
        }

        public int _acceleration { get; }
        public bool _isStreetLegal { get; }
        public Sport _type { get; }

        public override void Start()
        {
            Console.WriteLine("Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public void Race()
        {
            Console.WriteLine("Racing");
        }
    }

}