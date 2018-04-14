using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Program
    { 
    /* Instructies
    Maak een applicatie ToDoList. De applicatie ToDoList heeft een class ToDoList. 
    De class ToDoList heeft een instance variabele producten, wat een array is.
    Het arrayobject, bevat objecten van het type Product.
    De class product heeft de string naam en de int aantal als attributen. Maak de class product abstract.
    Maak van product twee subclasses, namelijk BuyFood en Shopping en initialiseert in de subclasses voor ieder attribuut een waarde. 
    Laat in een demo-applicatie zien dat er BuyFood en Shopping in de ToDoList geplaatst kunnen worden. */

        public static void Main(string[] args)
        {
            ToDoList thisMorning = new ToDoList();
            var thisAfternoon = thisMorning.tasks;
            foreach(var thisEvening in thisAfternoon)
            {
                Console.WriteLine(thisAfternoon);
            }
            Console.ReadLine();
        }
    }

    public class ToDoList
    {
        public List<Product> tasks = new List<Product>();
    }

    public abstract class Product
    {
        public abstract string Naam();
        public abstract int Aantal();
    }

    public class BuyFood : Product
    {
        public override string Naam()
        {
            return "Milk";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override int Aantal()
        {
            return 2;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class Shopping : Product
    {
        public override string Naam()
        {
            return "Shoe";
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public override int Aantal()
        {
            return 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
