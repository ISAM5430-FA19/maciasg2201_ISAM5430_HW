using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Motorway
    {
        private string _name;
        private string _type;
        private string _direction;
        private string _surface;
        private int _lanes;
        private bool _toll;
        private string _maintainedby;
        
        public Motorway(string name, string type, string surface)
        {
            Name = name;
            Type = type;
            Surface = surface;
        }

        public Motorway(string name, string type, string surface, int lanes)
        {
            Name = name;
            Type = type;
            Surface = surface;
            Lanes = lanes;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Type { get { return _type; } set { _type = value; } }
        public string Direction { get { return _direction; } set { _direction = value; } }
        public string Surface { get { return _surface; } set { _surface = value; } }
        public int Lanes { get { return _lanes; } set { _lanes = value; } }
        public bool Toll { get { return _toll; } set { _toll = value; } }
        public string MaintainedBy { get { return _maintainedby; } set { _maintainedby = value; } }

        public override string ToString()
        {
            return $"Name: {Name}\nType: {Type}\nDirection: {Direction}\nSurface: {Surface}\nLanes: {Lanes}\nToll: {Toll}\nMaintained By: {MaintainedBy}\n";
        }

    }
}
