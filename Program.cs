using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
			string firstFood = favFoods[0];
			string secondFood = favFoods[1];
			string thirdFood = favFoods[2];
			Console.WriteLine("I like {0}, {1}, and {2}", favFoods[0], favFoods[1], favFoods[2]);
        }
    }
}
