using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_1
{
    internal interface ICommerceVehicles
    {
        int _passengerCount { get; }
        double _kilometersPerLiter { get; }
        Commerce _type { get; }

        void GoOutWithFriends();
    }

    internal class CommerceVehicle : Vehicle, ICommerceVehicles
    {
        public CommerceVehicle(string name, string description, Vehicles category, int topSpeed, int distanceTraveled, int passengerCount, double kilometersPerLiter, Commerce type)
            : base(name, description, category, topSpeed, distanceTraveled)
        {
            _passengerCount = passengerCount;
            _kilometersPerLiter = kilometersPerLiter;
            _type = type;

        }

        public int _passengerCount { get; }
        public double _kilometersPerLiter { get; }
        public Commerce _type { get; }

        public void GoOutWithFriends()
        {
            Console.WriteLine("Going out with friends to hang out in my " + _name);
        }

        public override void Start()
        {
            Console.WriteLine("Started");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }

}