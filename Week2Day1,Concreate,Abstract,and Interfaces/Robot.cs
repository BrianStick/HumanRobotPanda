using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1_Concreate_Abstract_and_Interfaces
{
    public class Robot
    {
        public bool IsShutdown = true;
        private bool Tm103 { get; set; }
        public string Name { get; set; }

      

        public string DisplayName()
        {
            return this.
        }

        public string DisplayGreeting()
        {
            return "Hello There!!!";
        }

        public string StartUp()

        {
            IsShutdown = false;
            return "Start";
        }
        public string Shutdown()
        {
            return "Shutdown";
        }

        public bool IsTerminator()
        {
            return true;
        }

        public bool IsAsleep()
        {
            return IsShutdown; 

        }

    }    
     }




