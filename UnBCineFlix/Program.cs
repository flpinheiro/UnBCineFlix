using System;
using UnBCineFlix.DAL;

namespace UnBCineFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new UnBCineFlixContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Console.WriteLine("Hello World!");
        }
    }
}
