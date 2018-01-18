using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesList.Classes
{
    public class Bundle 
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

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        
        public override string ToString()
        {
            return Name;
        }

        public static int CompareByName(Bundle a, Bundle b)
        {
            return string.Compare(a.Name, b.Name);
        }

        public class BundleGame
        {
            private Game _game;
            public Game Game
            {
                get { return _game; }
                set { _game = value; }
            }
            
            private int _number;
            public int Number
            {
                get { return _number; }
                set { _number = value; }
            }

            public string Name { get { return Game != null ? Game.Name : ""; } }

            public bool Have { get { return Game != null ? Game.Have : false; } }

            public string Status { get { return Game != null ? Game.GamePlatform.GameStatusToString(Game.Status) : ""; } }

            public bool Ready { get { return Game != null ? Game.Ready : false; } }

            public string PlatformsString { get { return Game != null ? Game.PlatformsString : ""; } }

            public DateTime? Date { get
                {
                    if (Game != null)
                        return Game.Date;
                    else
                        return null;
                }
            }

            public static int CompareByNumber(BundleGame a, BundleGame b)
            {
                if (a.Number == b.Number)
                    return string.Compare(a.Name, b.Name);
                else
                    return a.Number - b.Number;
            }
        }
    }
}
