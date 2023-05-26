using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTime
{
    public class Employer
    {
        private int age;
        private string name;
        public Employer()
        {
            age = 0;
            name = "Сотрудник";
        }
        public Employer(int _age, string _name)
        {
            if (this.SetAge(_age))
            {
                this.age = _age;
                this.name = _name;
            }
        }

        public int Age { get { return age; } }
        public string Name { get { return name; } }
        public bool SetAge(int _age)
        {
            bool flag = false;
            if (_age >= 14 & _age <= 100)
            {
                age = _age;
                flag = true;
            }
            return flag;
        }
        public void SetName(string _name)
        {
            this.name = _name;
        }
        public virtual void PrintWorkTime()
        {
            Console.WriteLine($"Сотрудник {this.name} " +
                $"работает 5/7 8 часов в день");
        }
    }
    public class YoungEmployer : Employer
    {
        public YoungEmployer(int _age, string _name)
            : base(_age, _name) { }

        public new void PrintWorkTime()
        {
            if (this.Age < 18)
            {
                Console.WriteLine($"Сотрудник {this.Name} " +
                $"работает 5/7 4 часа в день");
            }
            else
            {
                base.PrintWorkTime();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employer staff001 = new Employer(20, "John");
            staff001.PrintWorkTime();
            YoungEmployer staff002 = new YoungEmployer(14, "Bill");
            staff002.PrintWorkTime();
            staff002.SetAge(20);
            staff002.PrintWorkTime();

        }
    }
}
