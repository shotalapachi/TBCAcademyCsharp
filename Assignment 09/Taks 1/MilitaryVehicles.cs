using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taks_1;

namespace Taks_1
{
    internal interface IMilitaryVehicle
    {
        bool _isArmed { get; }
        bool _isArmored { get; }
        Military _type { get; }

        void Attack();
    }

    internal class MilitaryVehicle : Vehicle, IMilitaryVehicle
    {
        public MilitaryVehicle(string name, string description, Vehicles category, int topSpeed, int distanceTraveled, bool isArmed, bool isAromerd, Military type)
            : base(name, description, category, topSpeed, distanceTraveled)
        {
            _isArmed = isArmed;
            _isArmored = isAromerd;
            _type = type;
        }

        public bool _isArmed { get; }
        public bool _isArmored { get; }
        public Military _type { get; }

        public void Attack()
        {
            if (_isArmed)
            {
                Console.WriteLine("Fire!!!");
            }
            else
            {
                Console.WriteLine("Vehicle isn't armed");
            }
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
