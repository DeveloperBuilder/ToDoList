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
            ToDoList tasks = new ToDoList();
            tasks.AddTask(new BuyFood());
            tasks.AddTask(new Shopping());
            foreach(var toDoTask in tasks.task)
            {
                Console.WriteLine($"The task are {toDoTask.Naam()} and the amount are {toDoTask.Aantal()}");
            }
            Console.ReadLine();
        }
    }

    public class ToDoList
    {
        public List<Product> task;

        public ToDoList()
        {
            task = new List<Product>();
        }

        public void AddTask(Product product)
        {
            task.Add(product);
        }
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
            Console.ForegroundColor = ConsoleColor.White;
            return "Milk";
        }
        public override int Aantal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return 2;
        }
    }

    public class Shopping : Product
    {
        public override string Naam()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return "Shoe";
        }
        public override int Aantal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return 1;
        }
    }
}
