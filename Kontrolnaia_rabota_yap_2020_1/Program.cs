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

            int nrow;
            int ncolumn;

            Console.WriteLine("<===== Введите количество строк и количество столбцов =====>");
            Console.WriteLine("*для разделения чисел при вводе можно использовать:\n \" \" - пробел \n \"&\" - знак и \n \"| \\ / \" - любую линию");
            Console.WriteLine("<Ввод>");

            string main_mass = Console.ReadLine();
            char[] deliters = { ' ', '&', '\\', '|', '/' };
            string[] second_mass = main_mass.Split(deliters, StringSplitOptions.RemoveEmptyEntries);

            nrow = Convert.ToInt32(second_mass[0]);
            ncolumn = Convert.ToInt32(second_mass[1]);

            Console.WriteLine($"{nrow} and {ncolumn}");

            int len = nrow * ncolumn;
            int[] mass_1 = new int[len];
            int[,] mass_2 = new int[nrow, ncolumn];
            
            for(int i = 0;i < len;i++)
            {
                mass_1[i] = i;
                i++;
            }

            int k = 0;
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    mass_2[i,j] = k;
                    j++;
                    k++;
                }
                i++;
            }


            //Допустим нам надо увеличить вск элменты на 15\\
            
            //Увеличения для одномерного массива\\
            int r = 0;

            float start = Environment.TickCount;
            while (r < len)
            {
                mass_1[r] = mass_1[r] + 15;
                r++;
            }
            float finish = Environment.TickCount;
            Console.WriteLine($"Время отработки одномерного массива > E={0:F10}", finish - start);

            r = 0;
            //Для прямоугольного массива\\
            int f = 0;
            start = Environment.TickCount;
            while (r < nrow)
            {
                while (f < ncolumn)
                {
                    mass_2[r, f] += 15;
                    f++;
                }
                r++;
            }
            finish = Environment.TickCount;
            Console.WriteLine($"Время отработки прямоугольного массива > E={0:F10}", finish - start);

            //==================================\\
            ResearchTeam std = new ResearchTeam(); 
            Console.WriteLine(std.ToShortString());
            //==================================\\
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
        public void AddPapers( params Paper[] a )
        {
            Papers.AddRange(new List<Paper>());
        }

        public override string ToString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\nPublications: {4} ", Theme, NameOfOrg, NumberOfRed, Last, Papers);
        }

        public string ToShortString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\n", Theme, NameOfOrg, NumberOfRed, Last);
        }
    }

}
