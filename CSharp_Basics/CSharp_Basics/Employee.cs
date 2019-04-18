using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    public class Employee
    {
        public string Name { get; }
        public int BadgeID { get;  }
        public Locations Location {get; }
        public Employee(string name, int badgeID, string location)
        {
            this.Name = name;
            this.BadgeID = badgeID;
            Locations temp;
            Enum.TryParse(location, out temp);
            Location = temp;
        }
        public Employee(string name, int badgeID, Locations location)
        {
            this.Name = name;
            this.BadgeID = badgeID;
            this.Location = location;
           
        }


        public string LocationToString()
        {
            return Location.ToString();
        }
        
        public bool IsNorthWarsaw()
        {
            if (Location == Locations.Koszalin || Location == Locations.Szczecin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
