using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaboratorOOP
{
    public class Motocyle : Vehicle
    {
        //mostenire implca crearea de noi clase pe baza claselor existente [entru reutiliza si extinde functionalitatea
        //clasa Car si MotoCyle mostenesc de la Vehicle

        //proprietate pentru a accesa daca motocileta are sau nu gaz.
        public bool Gaz {  get; set; }

        public Motocyle(string name,int year,bool gaz) :base(name,year)
        {
           this.Gaz = gaz;
        }

        public override void Start()
        {
            Console.WriteLine($"The {Name} {Year} motorcycle starts.");
        }

        // Destructor
        ~Motocyle()
        {
            Console.WriteLine($"Destroying a {Name} {Year} motorcycle.");
        }
    }
    
}
