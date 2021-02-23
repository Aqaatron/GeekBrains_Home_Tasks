using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace Task5__to_do_LIST_
{
    [Serializable]
    class ToDo
    {

        public List<(string, bool)> ToDo_List { get; set; }



        

        

        public ToDo(List<(string, bool)> ToDo_List)
        {
            this.ToDo_List = ToDo_List;


        }

        public ToDo ()
        {

        }

        public void mark_Task(int num_of_task)
        {

            ToDo_List[num_of_task - 1] = (ToDo_List[num_of_task - 1].Item1 + "              [x]", true);

               
            
        }

        public void delete_Task(int num_of_task)
        {

            ToDo_List.Remove(ToDo_List[num_of_task - 1]);



        }

        public void add_Do(string Title, bool isDone)
        {

            ToDo_List.Add((Title, isDone));

        }

        public void add_Do(string Title)
        {

            ToDo_List.Add((Title, false));

        }

        public void Seriaz (string filename)
        {
            StringWriter stringWriter = new StringWriter();

            XmlSerializer serializer = new XmlSerializer(typeof((string, bool)[]));

            (string, bool)[] array = ToDo_List.ToArray();

            serializer.Serialize(stringWriter, array);

            string xml = stringWriter.ToString();

            File.WriteAllText(filename, xml);

        }

        public void DeSeriaz(string filename)
        {
            string xmlText = File.ReadAllText(filename);

            StringReader stringReader = new StringReader(xmlText);

            XmlSerializer serializer = new XmlSerializer(typeof((string, bool)[]));

            (string, bool)[] array1 = ((string, bool)[])serializer.Deserialize(stringReader);

            ToDo_List = array1.ToList<(string, bool)>();

        }
        public void getList_console()
        {
            for (int i = 0; i < ToDo_List.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + ToDo_List[i].Item1);
                
            }
            Console.WriteLine();
        }



    }
}
