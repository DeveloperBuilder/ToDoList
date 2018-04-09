using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    { 
    /* Instructies
    Maak een applicatie ToDoList. De applicatie ToDoList heeft een class ToDoList. 
    De class ToDoList heeft een instance variabele producten, wat een array is.
    Het arrayobject, bevat objecten van het type Product.
    De class product heeft de string naam en de int aantal als attributen. Maak de class product abstract.
    Maak van product twee subclasses, namelijk BuyFood en Shopping en initialiseert in de subclasses voor ieder attribuut een waarde. 
    Laat in een demo-applicatie zien dat er BuyFood en Shopping in de ToDoList geplaatst kunnen worden. */

        static void Main(string[] args)
        {
        }
    }

    public class ToDoList
    {
        public List<Product> products;
        public ToDoList()
        {
            
        }
    }

    public abstract class Product
    {
        public string Naam;
        public int Aantal;
    }

    public class BuyFood : Product
    {
        string Melk;
        public void Supermarket(string Naam, int Aantal)
        {
            Naam = Melk;
            Aantal = 2;
        }
    }

    public class Shopping : Product
    {
        string Shoe;
        public void HudsonsBay(string Naam, int Aantal)
        {
            Naam = Shoe;
            Aantal = 1;
        }
    }
}
