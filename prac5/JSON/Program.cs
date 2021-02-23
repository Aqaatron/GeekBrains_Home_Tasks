using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace JSON

    //Разбор сериализации xml и json
{
    class Program
    {
        static void Main(string[] args)
        {
            //JSON



            //string filename = "sometext.txt";


            //Building building = new Building(2, 3, "Aassaas");


            //string srJSON = JsonSerializer.Serialize(buildings);


            //File.WriteAllText(filename, srJSON);


            //string srJSON1 = File.ReadAllText(filename);



            //Buildings house = JsonSerializer.Deserialize<Buildings>(srJSON1);


            //XML

            //StringWriter stringWriter = new StringWriter();

            //XmlSerializer serializer = new XmlSerializer(typeof(Building));

            //serializer.Serialize(stringWriter, building);

            //string xml = stringWriter.ToString();

            //File.WriteAllText("house.xml", xml);

            //string xmlText = File.ReadAllText("house1.xml");

            //StringReader stringReader = new StringReader(xmlText);

            //Building house1 = (Building)serializer.Deserialize(stringReader);


            //Binary Serialization

            //Building house_serialize = new Building(6, 3, "asgasgas");

            //BinaryFormatter formatter = new BinaryFormatter();

            //formatter.Serialize(new FileStream("house.bin", FileMode.OpenOrCreate), house_serialize);



            //Building house_desirialize = (Building)formatter.Deserialize(new FileStream("house.bin", FileMode.Open));

            //Console.WriteLine(house_desirialize.Adress);

            //Console.ReadLine();



            //NULL EXEPTION

            Building house = new Building(2, 3);

            house.Adress = "aghashas asgasg";

            Console.WriteLine(house.Adress.Split(' ')[1]);

            Console.WriteLine(house.Adress);

            Building house1 = new Building(3, 4);


            
            Console.WriteLine(house1?.Adress?.Split(' ')[1]);

            Console.WriteLine(house1.Adress??"Нет адреса");





            Console.ReadLine();
        }
    }
}
