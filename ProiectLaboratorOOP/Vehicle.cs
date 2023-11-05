using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorOOP
{
    public abstract  class Vehicle
    {
        //Abstractizarea = implica ascunderea detalilor de implementare si furnizarea unei interfete simplificate catre utilizator.
        //clasa de baza Car serveste drep abstractizare a conecptului de Car


        //proprietati pentru a accesa numele si anul masinii
        //public =  vizibil atat in interior cat si exteriorul clasei
        public string Name { get; set; }

        public int Year { get; set; }

        //constructor = initializeaza clasa
        //this specifica tip exact de date care va fi folosit
        public Vehicle(string name,int year)
        {
            this.Name = name;
            this.Year = year;
        }

        // Metoda abstractă , care trebuie implementată în clasele derivate
        public abstract void Start();

        //destructor
        //pentru a ilustra momentul distrugerii obiectelor în memoria gestionată de către C#.
        //Acești destructori afișează mesaje pentru a indica când un obiect de tip Vehicle, Car sau Motorcycle este distrus.
        //Distrugerea unui obiect are loc atunci când acesta nu mai este referențiat și nu mai este necesar.
        ~Vehicle()
        {
            Console.WriteLine($"Destroying an {Name} from {Year}");
        }
    }
}
