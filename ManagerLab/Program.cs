using System;

namespace ManagerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstManager = new Manager();
            var secondManager = new Manager();

            firstManager.SetSurname("Migal");
            firstManager.SetAge(19);
            firstManager.SetIsGoes(true);

            secondManager.SetSurname("Feduk");
            secondManager.SetAge(20);
            secondManager.SetIsGoes(false);

            firstManager.PrintAboutObject();
            secondManager.PrintAboutObject();
        }
    }
}
