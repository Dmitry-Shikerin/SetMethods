using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void CreateNewObject()
        {
            //Создание объекта на карте
        }

        public static void CreateRandomNumber()
        {
            _chance = Random.Range(0, 100);
        }

        public static int СalculateSalary(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
    }

}
