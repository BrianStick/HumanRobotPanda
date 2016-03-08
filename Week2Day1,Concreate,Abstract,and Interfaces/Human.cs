using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1_Concreate_Abstract_and_Interfaces
{
   public class Human
    {
        public bool Asleep = true;

        public string Name { get; set; }

        public string DisplayName()
        {
            return this.Name;
        }

        public string DisplayGreeting ()
        {
            return "Hello There!!!";
        }
        public void Eat(string  Food)
        {
           
            Console.WriteLine($"Yum I ate {Food}");
        }

        public void GoToSleep()
        {
            Console.WriteLine("Go to sleep!!");
        }
        public void WakeUp()
        {
            Console.WriteLine("Wake up!!");
        }
        public void IsAsleep()
        {
            if(Asleep)
            Console.WriteLine("Human is asleep!");

        }
       
        

    }

}
