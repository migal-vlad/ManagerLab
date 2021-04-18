using System;
namespace ManagerLab
{
    public class Manager
    {
        private string surname;
        private int age;
        private bool isGoes;

        private int Age { set { age = value >= 0 ? value : 0; } }
        private string Surname { set { surname = value.Trim(); } }

        public string GetSurname() => surname;
        public int GetAge() => age;
        public bool GetIsGoes() => isGoes;

        public void SetSurname(string surname) => Surname = surname;
        public void SetAge(int age) => Age = age;
        public void SetIsGoes(bool isGoes) => this.isGoes = isGoes;

        public void PrintAboutObject()
            => Console.WriteLine($"Surname: {surname}, Age: {age}, isGoes: {isGoes}");
    }
}
