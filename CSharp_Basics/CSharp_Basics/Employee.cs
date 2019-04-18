using System/;
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
            ValidateBadgeNumber(BadgeID, Location);
        }
        public Employee(string name, int badgeID, Locations location)
        {
            ValidateBadgeNumber(BadgeID, location);
            this.Name = name;
            this.BadgeID = badgeID;
            this.Location = location;
           
        }

        private void ValidateBadgeNumber(int badgeID, Locations location)
        {
           if (badgeID < 10000 && badgeID > 99999)
            {
                throw new ArgumentOutOfRangeException("Badge should have 5 digits");
            }
           if(IsNorthWarsaw() && BadgeID >= 60000)
            {
                return;
            }
            if (!IsNorthWarsaw() && BadgeID < 60000)
            {
                return;
            }
            throw new ArgumentOutOfRangeException("Badge is from wrong region");
        }

        public string LocationToString()
        {
            return Location.ToString();
        }
        
        public bool IsNorthWarsaw()
        {
            // polnoc id - 1-5 - 5 cyfr
            // poludnie id - 6-9 - - 5 cyfr
            // throw new ArgumentOutOfRangeException();
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
