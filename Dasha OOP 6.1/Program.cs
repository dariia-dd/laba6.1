using System;

namespace Dasha_OOP_6._1
{
    public class Student : IComparable
    {

        public string name;
        public string LastName;
        public string number;
        public float math;
        public float OOP;
        public float phisik;
        public float electronic;
        public float grafic;
        public float seredne;

        public Student(string name, string LastName, string number, float math, float OOP, float phisik, float electronic, float grafic, float seredne)
        {

            this.name = name;
            this.LastName = LastName;
            this.number = number;
            this.math = math;
            this.OOP = OOP;
            this.phisik = phisik;
            this.electronic = electronic;
            this.grafic = grafic;
            this.seredne = seredne;
        }
        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if (this.seredne < s.seredne) return 1;
            if (this.seredne > s.seredne) return -1;
            return 0;
        }
        public void Inf()
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-10}{4,-10}{5,-10}{6,-20}{7,-20}{8,-10}", name, LastName, number, math, OOP, phisik, electronic, grafic, seredne);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[10];
            s[0] = new Student("Данилова", "Дарія", "897393553", 88, 76, 73, 90, 81, (88 + 76 + 73 + 90 + 81) / 5);
            s[1] = new Student("Власенко", "Дарія", "897393553", 98, 86, 88, 99, 97, (98 + 86 + 88 + 99 + 97) / 5);
            s[2] = new Student("Химич", "Марян", "897393553", 77, 84, 81, 73, 79, (77 + 84 + 81 + 73 + 79) / 5);
            s[3] = new Student("Квас", "Тарас", "897393553", 59, 68, 63, 58, 77, (59 + 68 + 63 + 58 + 77) / 5);
            s[4] = new Student("Балух", "Ігор", "897393553", 83, 86, 74, 72, 67, (83 + 86 + 74 + 72 + 67) / 5);
            s[5] = new Student("Романко", "Віталій", "897393553", 98, 88, 88, 99, 100, (98 + 88 + 88 + 99 + 100) / 5);
            s[6] = new Student("Кахній", "Роман", "897393553", 50, 50, 59, 54, 61, (50 + 50 + 59 + 54 + 61) / 5);
            s[7] = new Student("Голинський", "Руслан", "897393553", 70, 80, 81, 60, 50, (70 + 80 + 81 + 60 + 50) / 5);
            s[8] = new Student("Бабій", "Артур", "897393553", 68, 76, 78, 79, 81, (68 + 76 + 78 + 79 + 81) / 5);
            s[9] = new Student("Стащук", "Василь", "897393553", 50, 59, 60, 57, 60, (50 + 59 + 60 + 57 + 60) / 5);
            Array.Sort(s);
            Console.WriteLine("{0,-20} {1,-20} {2,-30} {3,-10}{4,-10}{5,-10}{6,-20}{7,-20}{8,-10}", "Прізвище", "Імя", "Номер", "Матем", "Фізика", "ООП", "Графіка", "Електроніка", "Середнє");
            foreach (Student elem in s) elem.Inf();
            float n = 0;
            for (int i = 0; i < 10; i++)
            {
                if (s[i] != null)
                {
                    if (s[i].seredne > 77)
                    {
                        n++;

                    }
                }
            }

            float vid = (n / 10) * 100;

            Console.WriteLine("Відсоток студентів, середній бал яких відповідає оцінкам “добре” та “відмінно”: {0}%", vid);
        }
    }
}