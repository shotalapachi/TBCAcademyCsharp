using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_1
{
    internal abstract class Vehicle
    {
        internal string? _name;
        internal string? _description;
        internal Vehicles _category;
        internal int _topSpeed;
        internal int _distanceTraveled;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Vehicles Category { get { return _category; } set { _category = value; } }
        public int TopSpeed { get { return _topSpeed; } set { _topSpeed = value; } }
        public int DistanceTraveled { get { return _distanceTraveled; } }

        public Vehicle(string name, string description, Vehicles category, int topSpeed, int distanceTraveled)
        {
            _name = name;
            _distanceTraveled = distanceTraveled;
            _description = description;
            _category = category;
            _topSpeed = topSpeed;
        }

        public void Drive(int distance)
        { 
            this._distanceTraveled += distance;
        }
        public abstract void Start();

        public abstract void Stop();
    }
}
