using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorOOP
{
    public class Car : Vehicle
    {
        //Incapsularea =  implca impachetarea datelor si comportamentului intr-o singura unitate,astfel incat sa fie vizibila
        //doar metodelor necesare pentru utilizatori.
        public int NumberOfDoors { get; set; }

        public Car(string name, int year,int numberOfDoors) : base(name,year)
        {
            this.NumberOfDoors = numberOfDoors;
        }

        // Implementarea metodei abstracte Start pentru clasa Car
        public override void Start()
        {
            Console.WriteLine($"The {Name} {Year} car starts.");
        }

        // Destructor
        //
        ~Car()
        {
            Console.WriteLine($"Destroying a {Name} {Year} car.");
        }
    }
}
