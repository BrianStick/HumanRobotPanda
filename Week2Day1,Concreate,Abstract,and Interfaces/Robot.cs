using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day1_Concreate_Abstract_and_Interfaces
{
    public class Robot
    {

        private bool Tm103 { get; set; }
        public string Name { get; set; }

        public string DisplayName()
        {
            return this.Name;
        }

        public string DisplayGreeting()
        {
            return "Hello There!!!";
        }

        public string StartUp()

        {
            return "Start";
        }
        public string Shutdown()
        {
            return "Showdown";
        }

        public bool IsTerminator()
        {
            return true;
        }


        

    }    
     }




