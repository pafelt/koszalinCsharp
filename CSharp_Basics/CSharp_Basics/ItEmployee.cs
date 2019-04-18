using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
   public class ItEmployee : Employee
    {
    

        public ItEmployee (string name, int badgeID, string location, string programmingLanguage) : base (name,badgeID,location)
        {
            ProgrammingLanguages temp;
            Enum.TryParse(programmingLanguage, out temp);
            this.ProgrammingLanguage = temp;
        }

        public ProgrammingLanguages ProgrammingLanguage { get; }
        public ItEmployee(string name, int badgeID, Locations location, ProgrammingLanguages programmingLanguage) : base(name, badgeID, location)
        {
            this.ProgrammingLanguage = programmingLanguage;

        }

        public string ProgrammingToString()
        {
            return ProgrammingLanguage.ToString();
        }



    }
}
