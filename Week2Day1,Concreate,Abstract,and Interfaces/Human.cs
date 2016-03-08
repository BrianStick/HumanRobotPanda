using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1_Concreate_Abstract_and_Interfaces
{
   public class Human
    {
        public bool IsAsleep = true;

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

        public string GoToSleep()
        {
            ????
        }
        public string WakeUp()
        {
            ???
        }

    }

}
