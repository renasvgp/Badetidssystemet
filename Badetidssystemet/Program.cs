using System;
using System.Collections.Generic;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {

            Kreds kreds = new Kreds("1", "Karen", "Strandvejen 2");

            
            BadeTidsPeriode badetidsperiode = new BadeTidsPeriode("Morgern Dukkert",
                                                  DayOfWeek.Monday,
                                                  new DateTime().AddHours(6).AddMinutes(30),
                                                  new DateTime().AddHours(8).AddMinutes(30));

            Console.WriteLine(kreds);
            Console.WriteLine(badetidsperiode);

        }

        
    }
}
