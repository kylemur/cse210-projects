using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";

        Console.Write("Do you want Enos or Nephi? ");
        string scripture = Console.ReadLine();




        if (scripture == "Enos")
        {
            Scripture scriptureTest = new Scripture();

            while (answer != "quit")
            {
                Console.Clear();
                scriptureTest.Show();

                Console.Write("\n\nPress enter to continue, 'u' to undo, or 'quit' to finish: ");
                answer = Console.ReadLine();

                if (answer == "u")
                {
                    scriptureTest.Undo();
                    scriptureTest.Undo();
                    scriptureTest.Undo();
                }
                else if (scriptureTest.ShownIndexesCount() == 0)
                {
                    answer = "quit";
                }
                else
                {
                    scriptureTest.HideOneWord();
                    scriptureTest.HideOneWord();
                    scriptureTest.HideOneWord();
                }
            }
        }




        else if (scripture == "Nephi")
        {
            Reference reference1 = new Reference("1 Nephi", 3, 7);

            string nephi = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

            Scripture scripture1 = new Scripture(reference1.GetReference(), nephi);

            while (answer != "quit")
            {
                Console.Clear();
                scripture1.Show();

                Console.Write("\n\nPress enter to continue, 'u' to undo, or 'quit' to finish: ");
                answer = Console.ReadLine();

                if (answer == "u")
                {
                    scripture1.Undo();
                    scripture1.Undo();
                    scripture1.Undo();
                }
                else if (scripture1.ShownIndexesCount() == 0)
                {
                    answer = "quit";
                }
                else
                {
                    scripture1.HideOneWord();
                    scripture1.HideOneWord();
                    scripture1.HideOneWord();
                }
            }
        }




        else
        {
            Console.WriteLine("Incorrect input.");
        }
    }
}