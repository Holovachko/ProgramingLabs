using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Lab1XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Pretendent person1 = new Pretendent("Anton Ivanov" , "green" , 10000 , 18 , true);
            Pretendent person2 = new Pretendent("Ivan Petrenko" , "blue" , 5000 , 21 , false);
            Pretendent person3 = new Pretendent("Misha Zaharov" ,"blue" , 20000 , 30 , true);
            Pretendent person4 = new Pretendent("Vasyl Kiselev" , "green" , 50000 , 33 , true);
            Pretendent person5 = new Pretendent("John Shelby" , "brown" , 15000 , 23 , false);
            Pretendent[] pretends = new Pretendent[] { person1, person2, person3, person4, person5 };
            XmlSerializer formatter = new XmlSerializer(typeof(Pretendent[]));

            using (FileStream fs = new FileStream("staff.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, pretends);
            }

            using (FileStream fs = new FileStream("staff.xml", FileMode.OpenOrCreate))
            {
                Pretendent[] newEmployee = (Pretendent[])formatter.Deserialize(fs);

                foreach (Pretendent e in newEmployee)
                {
                    Console.WriteLine($" {e.Fullname}  {e.Apartament}  {e.Salary}  {e.Age}  {e.EyesColor}");
                }
            }
            Console.ReadLine();
        }
    }
    }

