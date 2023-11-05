using System;

namespace ProiectLaboratorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //obiect al clase car care preia proprietatile initializate in constructri
            Car myCar = new Car("Audi", 2008, 4);
            Motocyle myMoto = new Motocyle("Harley-Davidson", 2012, true);


            //polimorfism
            //am creat un vector ce contine obiectele respective
            //vectorul poate stoca doarece doarece ele mostenesc de la Vehicle
            //iterez prin foreach si afisam informatii generale
            Vehicle[] vehicles = new Vehicle[] { myCar, myMoto };
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle : {vehicle.Name} from {vehicle.Year}");
                vehicle.Start();
                Console.WriteLine();
            }

            //polimorfismul este evident in bulca unde obiectele car si motocycle sunt trate in mod uniform
            //ca obiecte de tip vehicle
            //metoda start,apelată pentru fiecare obiect va executa codul specific pentru tipul de vehicul. Cu alte cuvinte, atunci când apelăm vehicle.Start(),
            //în funcție de tipul real al obiectului (mașină sau motocicletă), se va apela implementarea specifică corespunzătoare din clasa Car sau Motorcycle.
            //Acest lucru oferă un comportament polimorfic, permitându-ne să tratați vehiculele de tipuri diferite în mod uniform, fără a ști exact de ce tip sunt.
        }

    }

}