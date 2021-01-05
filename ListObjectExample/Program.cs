using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Security.Cryptography;

namespace ListObjectExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // make the list, note the trailing 's'
            List<Mp3Player> mp3Players = new List<Mp3Player>();
            
            // fill in the details:

            Console.WriteLine($"The list: mp3Players has now: {mp3Players.Count} player(s)");
            Mp3Player mp1 = new Mp3Player(1, "Make", "Model", 12.33);
            Mp3Player mp2 = new Mp3Player(2, "Make2", "Model2", 24.66);
            mp3Players.Add(mp1);
            mp3Players.Add(mp2);
            
            // does it work?!
            Console.WriteLine($"The list: mp3Players has now: {mp3Players.Count} player(s)");
            
            // print everything:
            foreach (Mp3Player m in mp3Players)
            {
                Console.WriteLine($"[{m.Id}] {m.Make} - {m.Model} cost: €{m.Price}");
            }
        }
    }
    public class Mp3Player
    {
        private int id;
        private string make;
        private string model;
        private double price;


        // constructor
        public Mp3Player()
        {
            // empty
        }

        public Mp3Player(int id, string make, string model, double price)
        {
            this.id = id;
            this.make = make;
            this.model = model;
            this.price = price;
        } 
        
        // properties
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Make
        {
            get => make;
            set => make = value;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}