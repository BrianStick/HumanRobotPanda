using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1_Concreate_Abstract_and_Interfaces
{
    public class Panda
    {
        public bool ASleep = true;

        public string Name { get; set; }

        public string DisplayName()
        {
            return this.Name;
        }

        public string DisplayGreeting()
        {
            return "Hello There!!!";
        }
        public void Eat(string food)
        {

            Console.WriteLine($"Yum I ate {food}");
        }
        public void GoToSleep()
        {
            Console.WriteLine("Got to Sleep!!");
        }
        public void WakeUp()
        {
            Console.WriteLine("Wake up!!!");
        }
        public void IsAsleep()
        {
            if (ASleep)
                Console.WriteLine("Panda is alseep!");
        }
       
    }
