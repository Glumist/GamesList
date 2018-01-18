using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesList.Classes
{
    public class Platform 
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _shortName;
        public string ShortName
        {
            get { return _shortName; }
            set { _shortName = value; }
        }

        private bool _have = true;
        public bool Have
        {
            get { return _have; }
            set { _have = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareByName(Platform a, Platform b)
        {
            return string.Compare(a.Name, b.Name);
        }
    }
}
