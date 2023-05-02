using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Patient
{
    public string Gender;
    public int Age;
    public string Name;
    public string Adress;

    public void Print() 
    {
        Console.WriteLine("Информация о больном");
        Console.WriteLine($"Пол:{Gender}");
        Console.WriteLine($"Возраст:{Age}");
        Console.WriteLine($"Имя:{Name}");
        Console.WriteLine($"Адрес:{Adress}");
    }
}


namespace JustProb2
{
    internal class Program
    {
        static Patient GetPatient()
        {
            var patient = new Patient();
            Console.WriteLine("Введите пол");
            patient.Gender = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            patient.Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            patient.Adress = Console.ReadLine();
            return patient;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Пациент 1");
            var firstPatient = GetPatient();
            Console.WriteLine("Пациент 2");
            var secondPatient = GetPatient();
            Console.WriteLine("Пациент 3");
            var thirdPatient = GetPatient();
            Console.WriteLine("Пациент 4");
            var fourthPatient = GetPatient();
            Console.WriteLine("Пациент 5");
            var fifthPatient = GetPatient();
            Console.WriteLine();
            fifthPatient.Print();
            Console.WriteLine();
            firstPatient.Print();
            Console.WriteLine();
            secondPatient.Print();
            Console.WriteLine();
            thirdPatient.Print();
            Console.WriteLine();
            fourthPatient.Print();
        }
    }
}
