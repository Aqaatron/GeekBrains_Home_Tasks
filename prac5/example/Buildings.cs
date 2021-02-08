using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Buildings
    {
       
        public int Floors { get; }

       
        public int Entrances { get; }

       
        public bool IsHeatable { get; set; }

        public string Adress { get; set; }

        
        public Buildings(int floors, int entrances)
        {
            Floors = floors;
            Entrances = entrances;
        }

      
        public void GetElevator (int entrance, int floor)
        {
            Console.WriteLine("3..2..1..Ding!");
        }

        
        public void OpenDoor (int entrance)
        {
            Console.WriteLine("Please come in!");
        }

        public void ChangeAdress (string NewAdress)
        {
            Adress = NewAdress;

        }

    }
}
