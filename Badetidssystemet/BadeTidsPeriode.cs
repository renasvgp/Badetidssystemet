using System;
using System.Collections.Generic;
namespace Badetidssystemet
{
    public class BadeTidsPeriode
    {
        public string type { get; set; }
        public DayOfWeek ugeDag { get; set; }
        public DateTime StartTidspunktet { get; set; }
        public DateTime SlutTidspunktet { get; set; }

        Dictionary<string, Kreds> Kreds = new Dictionary<string, Kreds>();

        public BadeTidsPeriode(string aType, DayOfWeek aUgeDag, DateTime aStartTidspunktet, DateTime aSlutTidspunktet)
        {
            type = aType;
            ugeDag = aUgeDag;
            StartTidspunktet = aStartTidspunktet;
            SlutTidspunktet = aSlutTidspunktet;
        }

        public void AddKreds(Kreds kreds)
        {
            Kreds.Add(kreds.id, kreds);
        }

        public void SletKreds(Kreds kreds)
        {
            Kreds.Remove(kreds.id);
        }

        public override string ToString()
        {
            
            return "Start tidspunktet for begivenheden er " + StartTidspunktet.TimeOfDay + " og begivenheden slutter er " + SlutTidspunktet.TimeOfDay;
        }

        public int AntalDeltagere
        {
            get { return AntalDeltagere; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Antal deltagere kan ikke være nul");
            }
        }

       
        
    }
}
