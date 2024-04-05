using System;



namespace TK_Aks
{
    public class TK_Aks
    {


        static void Main(string[] args)
        {
            int totalMark = 0;
            int[] maxGrade = { 10, 50, 30, 10 };
            


            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Введите количество баллов за {i} задание:");
                int mark;
                while (!int.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > maxGrade[i - 1])
                {
                    Console.WriteLine($"Введите конкретное значение от 0 до {maxGrade[i - 1]}");
                }
                totalMark += mark;
            }
            CalculateGrade(totalMark);
            Console.ReadKey();
            
        }
        public static int CalculateGrade(int totalMark)
        {

            int grade;
            if (totalMark <= 100 & totalMark >= 70)
            {
                grade = 5;
            }
            else if (totalMark <= 69 & totalMark >= 40)
            {
                grade = 4;
            }
            else if (totalMark <= 39 & totalMark >= 20)
            {
                grade = 3;
            }
            else
            {
                grade = 2;
            }
            Console.WriteLine("Your grade is " + grade);
            return grade;
        }
    }
}
