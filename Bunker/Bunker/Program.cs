using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Bunker.Creatures;
using Bunker.GameEngine;

namespace Bunker
{
    internal class Program
    {
        /*public static int nameBunker;
        public static int localBunker;
        public static int squareBunker;
        public static int capacityBunker;
        public static int timeOfstayBunker;
        public static int descriptionBunker;
        public static int premisesBunker;
        public static int availableResources;*/
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Player player = null;
            Engine engine = new Engine();
            player = engine.CreatePlayer();

            engine.History();
            Thread.Sleep(1500);
            player.showInfo();
            
            Console.ReadLine();
        }
    }
}
