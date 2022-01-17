using System;

namespace Exercise_02
{
    class StudentTest1
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input number of student you want to Infor: ");
            n = int.Parse(Console.ReadLine());
            Student0102[] list = new Student0102[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nInput the information of Student {0}: ", i + 1);
                list[i] = new Student0102();
                list[i].inputInfor();
            }
            //CRITERIAL 

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nFirst criterial : ");
                if (list[i].calculateAverage() >= 7 && list[i].Mark1 > 5 && list[i].Mark2 > 5 && list[i].Mark3 > 5)
                {
                    list[i].displayInfor();
                    break;
                }
                Console.WriteLine("\nSencond criterial : ");
                if (list[i].calculateAverage() < 7 && list[i].Mark1 >= 5 && list[i].Mark2 >= 5 && list[i].Mark3 >= 5)
                {
                    list[i].displayInfor();
                    break;
                }
                Console.WriteLine("\nThird criterial : ");
                if (list[i].Mark1 < 5 || list[i].Mark2 < 5 || list[i].Mark3 < 5)
                {
                    list[i].displayInfor();
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
