using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            User use1 = new User("Kenan Nagiyev", 1);
            use1.ShowInfo();
            User use2 = new User("Kenan Nagiyev", 2);
            use2.ShowInfo();

            Console.WriteLine("------Menu------");

            int choose = 0;
            do
            {
                switch (choose)
                {
                    case 1:
                        use1.ShowInfo();
                        break;
                    case 2:

                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
