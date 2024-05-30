using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");



        Scripture scriptureTest = new Scripture();



        Reference reference1 = new Reference("1 Nephi", 3, 7);

        string nephi = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Scripture scripture1 = new Scripture(reference1.GetReference(), nephi);

    }
}