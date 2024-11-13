namespace Studentregistreringsprogram_inlämningsuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new UserMenu();

            while (true) 
            {
                menu.UserMenuChoice();
            }

        }
    }
}
