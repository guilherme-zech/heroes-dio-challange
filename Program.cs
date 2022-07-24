using Heroes.src.Entities;

namespace Heroes{
    class Program
    {

        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight");
            Wizard jennica = new Wizard("Jennica", 42, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");
          
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());
        }
    }


}

