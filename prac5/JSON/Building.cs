using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    [Serializable]
    public class Building
    {
       
        public int Floors { get; set; }

       
        public int Entrances { get; set; }

        private bool IsHeatable { get; set; }

        public string Adress { get; set; }

        public Building()
        {

        }
        public Building(int floors, int entrances)
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

        public void ChangeAdress(string NewAdress)
        {
            Adress = NewAdress;

        }

    }
}
