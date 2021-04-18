using System;

namespace ManagerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstManager = new Manager();
            var secondManager = new Manager("Migol");
            var thirdManager = new Manager("Feduk", 18, false);
            var foruthManager = new Manager(thirdManager);

            firstManager.PrintAboutObject();
            secondManager.PrintAboutObject();
            thirdManager.PrintAboutObject();
            foruthManager.PrintAboutObject();
        }
    }
}
