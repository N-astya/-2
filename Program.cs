using System;
namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            Book secondBook = new Book();
            Magazine magazine = new Magazine();
            Magazine secondMagazine = new Magazine();
            Printable[] printable = { book, secondMagazine, magazine, secondBook };
            foreach (Printable item in printable)
            {
                item.Print();
            }


            Book.printBook(printable);
            Magazine.printMagazines(printable);
            Guitar guitar = new Guitar(12);
            Drum drum = new Drum(50);
            Trumpet trumpet = new Trumpet(175);
            Instrument[] instruments = { guitar, drum, trumpet };
            foreach (Instrument item in instruments)
            {
                item.Play();
            }
        }
    }
    interface Printable
    {
        void Print();
    }
    class Book : Printable
    {
        public static void printBook(Printable[] printable)
        {
            foreach (var item in printable)
            {
                if (item.GetType() == typeof(Book))
                {
                    item.Print();
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("книги");
        }
    }
    class Magazine : Printable
    {
        public static void printMagazines(Printable[] printable)
        {
            foreach (var item in printable)
            {
                if (item.GetType() == typeof(Magazine))
                {
                    item.Print();
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("журналы");
        }
    }
    interface Instrument
    {
        void Play();
        const string KEY = "До мажор";
    }
    class Guitar : Instrument
    {
        public Guitar(int stringsCount)
        {
            this.stringsCount = stringsCount;
        }
        private int stringsCount;

        public void Play()
        {
            Console.WriteLine("Играет гитара, количество струн - " + stringsCount);
        }
    }
    class Drum : Instrument
    {
        public Drum(int size)
        {
            this.size = size;
        }
        private int size;

        public void Play()
        {
            Console.WriteLine("Играет барабан, размер барабана - " + size);
        }
    }
    class Trumpet : Instrument
    {
        public Trumpet(int diameter)
        {
            this.diameter = diameter;
        }
        private int diameter;

        public void Play()
        {
            Console.WriteLine("Играет труба, её диаметр - " + diameter);
        }
    }
}

