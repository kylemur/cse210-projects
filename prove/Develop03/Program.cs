using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Do you want to end? ");
        // string answer = Console.ReadLine();
        string answer = "no";

        // while (answer != "yes")
        // {
        //     for 1 = 1 to 3:
        //         Console.Write("Do you want to end? ");
        //         answer = Console.ReadLine();
        //         Scripture scriptureTest = new Scripture();
        // }
        

        Scripture scriptureTest = new Scripture();

        while (answer != "yes")
        {
            Console.Write("Do you want to end? ");
            answer = Console.ReadLine();

            scriptureTest.HideOneWord();
            scriptureTest.HideOneWord();
            scriptureTest.HideOneWord();
            scriptureTest.Show();
        }

        // Reference reference1 = new Reference("1 Nephi", 3, 7);

        // string nephi = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        // Scripture scripture1 = new Scripture(reference1.GetReference(), nephi);

    }
}