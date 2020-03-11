using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Policy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size :");
            int size=int.Parse(Console.ReadLine());
            int[] grades = new int[size];
            for(int row=0;row< grades.Length;row++)
            {
                Console.Write("Enter Marks of Student {0} =",row);
                grades[row] = int.Parse(Console.ReadLine());
            }
            
            for(int row=0;row< grades.Length;row++)
            {
                if(grades[row]>=95 && grades[row]<=100)
                {

                    if(100- grades[row]<3)
                    {
                        grades[row] = 100;
                    }
                }
                else if (grades[row] >= 90 && grades[row] <= 95)
                {

                    if (95 - grades[row] < 3)
                    {
                        grades[row] = 95;
                    }
                }
                else if (grades[row] >= 85 && grades[row] <= 90)
                {

                    if (90 - grades[row] < 3)
                    {
                        grades[row] = 90;
                    }
                }
                else if (grades[row] >= 80 && grades[row] <= 85)
                {

                    if (85 - grades[row] < 3)
                    {
                        grades[row] = 85;
                    }
                }
                else if (grades[row] >= 75 && grades[row] <= 80)
                {

                    if (80 - grades[row] < 3)
                    {
                        grades[row] = 80;
                    }
                }
                else if (grades[row] >= 70 && grades[row] <= 75)
                {

                    if (75 - grades[row] < 3)
                    {
                        grades[row] = 75;
                    }
                }
                else if (grades[row] >= 65 && grades[row] <= 70)
                {

                    if (70 - grades[row] < 3)
                    {
                        grades[row] = 70;
                    }
                }
                else if (grades[row] >= 60 && grades[row] <= 65)
                {

                    if (65 - grades[row] < 3)
                    {
                        grades[row] = 65;
                    }
                }
                else if (grades[row] >= 55 && grades[row] <= 60)
                {

                    if (60 - grades[row] < 3)
                    {
                        grades[row] = 60;
                    }
                }
                else if (grades[row] >= 50 && grades[row] <= 55)
                {

                    if (55 - grades[row] < 3)
                    {
                        grades[row] = 55;
                    }
                }
                else if (grades[row] >= 45 && grades[row] <= 50)
                {

                    if (50 - grades[row] < 3)
                    {
                        grades[row] = 50;
                    }
                }
                else if (grades[row] >= 40 && grades[row] <= 45)
                {

                    if (45 - grades[row] < 3)
                    {
                        grades[row] = 45;
                    }
                }
                else if (grades[row] >= 38 && grades[row] <= 40)
                {

                    if (40 - grades[row] < 3)
                    {
                        grades[row] = 40;
                    }
                }
                else
                {
                    if(grades[row]<38)
                    {
                        grades[row] = grades[row];
                    }
                }
            }
            for(int row=0;row< grades.Length;row++)
            {
                Console.Write(" "+ grades[row]);
                
            }
            Console.Read();
        }

    }
}
