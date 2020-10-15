using System;
using System.Data;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolnaia_rabota_yap_2020_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam std = new ResearchTeam(); 
            Console.WriteLine(std.ToShortString());

            int nrow = 2;
            int ncolumn = 3;
            int[] mass_1 = new int[nrow * ncolumn];
            int[,] mass_2 = new int[nrow, ncolumn];

            Console.WriteLine("Hello World!");
        }
    }
    class Person
    {
        private 

        string name;
        string secondname;
        System.DateTime BDate;

        public Person(string personname, string personsecondname, DateTime personBDate)
        {
            name = personname;
            secondname = personsecondname;
            BDate = personBDate;
        }

        public Person() : this("Default_Name", "Default_Sname", new DateTime(1990, 22, 13))
        { }

        public string PersonName
        {
            get
            {
                return name;
            }
        }

        public string PersonSecondName
        {
            get
            {
                return secondname;
            }
        }

        DateTime PersonBDate
        {
            get
            {
                return BDate;
            }
        }

        int intPersonBDate
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
            return string.Format("{0} {1}\nDate of birth: {2}", name, secondname, BDate);
        }

        public string ToShortString()
        {
            return "\n" + "Имя: " + name + "\n" + "Фамилия: " + secondname;
        }

    }

    enum TimeFrame {Year,TwoYears,Long}

    class Paper
    {
        public

        string NameP { get; set; }
        Person Author { get; set; } 
        DateTime Data { get; set; } 

        public Paper(string name, Person author, DateTime data)
        {
            NameP = name;
            Author = author;
            Data = data;
        }

        // конструктор без параметров, инициализирующий все свойства класса некоторыми значениями по умолчанию
        private Paper() : this("WarandWorld", new Person("Timo","Melni",new DateTime(2001,10,18)), new DateTime(1999, 10, 1))
        { }


           
        public override string ToString()
        {
            return string.Format("Author  {0} write book {1}. Data = {2}", NameP, Author, Data);
        }
    }

    class ResearchTeam
    {
        private string Theme;
        private string NameOfOrg;
        private int NumberOfRed;
        private TimeFrame Last;
        private List<Paper> Papers = new List<Paper>();


        //В классе ResearchTeam определить конструкторы
        //Конструктор c параметрами типа string, string, int, TimeFrame для инициализации соответствующих полей класса


        public ResearchTeam(string theme, string nameoforg, int numberofred, TimeFrame last)
        {
            Theme = theme;
            NameOfOrg = nameoforg;
            NumberOfRed = numberofred;
            Last = last;
        }

        //Конструктор без параметров, инициализирующий поля класса значениями по умолчанию
        public ResearchTeam() : this("BlackLife","GoodDay",2005, new TimeFrame())
        { }

        public string theme
        {
            get
            {
                return Theme;
            }
        }

        public string nameoforg
        {
            get
            {
                return NameOfOrg;
            }
        }

        public int numberofred
        {
            get
            {
                return NumberOfRed;
            }
        }

        public TimeFrame last
        {
            get
            {
                return Last;
            }
        }

        public IReadOnlyList<Paper> Publications
        {
            get
            {
                return Papers.AsReadOnly();
            }
        }


        /*public double ListPublic
        {
            get
            {
                double averageGrade = _passedExams.Average(avgrade => avgrade.Grade);
                return averageGrade;
                return null;
            }
        }
        */

        public bool this[TimeFrame rez_prov]
        {
            get
            {
                bool rez;
                if (this.Last == rez_prov) rez = true;
                else rez = false;
                return rez;
            }
        }


        //Метод void AddPapers ( params Paper[] ) для добавления элементов в список публикаций
        public void AddPapers(params Paper[])
        {
            Papers.AddRange();
        }

        public override string ToString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\nPublications: {4} ", Theme, NameOfOrg, NumberOfRed, Last, _publications);
        }

        public string ToShortString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\n", Theme, NameOfOrg, NumberOfRed, Last);
        }
    }

}
