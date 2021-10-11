using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Quiz
{
    class Program
    {
        public static void Main()
        {
            int total_marks = 0, total_questions = 0;
            FileStream fs = new FileStream(@"C:\Training\Assignment3\Quiz\Quiz\sample-quiz-file.txt", FileMode.Open, FileAccess.Read);
            StreamReader fr = new StreamReader(fs);

            while (fr.Peek() > 0)
            {
                string line = fr.ReadLine();
                string[] contents = line.Split('|');

                string question = contents[0];
                Console.WriteLine("Question " + (total_questions + 1) + ":");
                Console.WriteLine(question);
                int answer = 0;
                for (int i = 1; i < contents.Length; i++)
                {
                    if (contents[i].Contains('*'))
                    {
                        answer = i;
                        contents[i] = contents[i].Trim('*');
                    }
                    Console.WriteLine(i + ")" + contents[i]);
                }

                Console.Write("Your answer:");
                int marked_option = Convert.ToInt32(Console.ReadLine());
                total_questions++;
                if (marked_option == answer)
                {
                    Console.WriteLine("Correct Answer!\n");
                    total_marks++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer!\n");
                }
            }

            Console.WriteLine("You got " + total_marks + " answer(s) correct out of the total " + total_questions + " question(s) asked");

            Console.Read();
        }

    }
}
