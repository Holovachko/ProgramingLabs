using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Lab1XML
{
    [Serializable]
    public class Pretendent
    {
        public string Fullname { get; set; }
        public string EyesColor { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public bool Apartament  { get; set; }

        public Pretendent(string fullname , string eyescolor , double salary , int age , bool apartament)
        {
            Fullname = fullname;
            EyesColor = eyescolor;
            Salary = salary;
            Age = age;
            Apartament = apartament;
        }
        public Pretendent()
        {

        }
    }
    
}
