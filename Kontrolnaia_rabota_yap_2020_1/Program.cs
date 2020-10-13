using System;
using System.Data;
using System.Numerics;

namespace Kontrolnaia_rabota_yap_2020_1
{
    class Program
    {
        class Person
        {
            private string name;
            private string secondname;
            private System.DateTime BDate;

            public Person(string personname, string personsecondname, DateTime personBDate)
            {
                this.name = personname;
                this.secondname = personsecondname;
                this.BDate = personBDate;
            }

            private string perpsonname;
            public string Name
            {
                get
                {
                    return name;
                }
            }

            private string perpsonsecondname;
            public string SecondName
            {
                get
                {
                    return name;
                }
            }

            DateTime personBDate
            {
                get
                {
                    return BDate;
                }
            }

            int intpersonBDate
            {
                get
                {
                    return Convert.ToInt32(BDate);
                }

                set
                {
                    BDate = Convert.ToDateTime(value);
                }
            }

            public override string ToString()
            {
                return string.Format("{0} {1}\nDate of birth: {2}", Name, SecondName, BDate);
            }

            public string ToShortString()
            {
                return "\n" + "Имя: " + Name + "\n" + "Фамилия: " + SecondName;
            }

        }
        static void Main(string[] args)
        {
            int nrow = 2;
            int ncolumn = 3;
            int[] mass_1 = new int[nrow * ncolumn];
            int[,] mass_2 = new int[nrow, ncolumn];

            Console.WriteLine("Hello World!");
        }
    }
}
