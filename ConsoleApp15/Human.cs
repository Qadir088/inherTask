using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age {  get; set; }
        public int[] Grades { get; set; } = new int[0];

        public Human(string name, string surname,byte age, int[] grades) 
        {
            Name = name;
            Surname = surname;
            Age = age;
            for(int i = 0; i < Grades.Length; i++)
            {
                if (grades[i] %2== 0)
                {
                    Grades = Grades.Append(grades[i]).ToArray();
                }
            }
        
        }
        public void getNum(Human  human)
        {
            foreach (var item in human.Grades)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
