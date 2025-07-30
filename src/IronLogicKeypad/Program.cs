using System;
using IronLogicKeyPad;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Write your sequence: ");
        string sequence = Console.ReadLine();

        string translatedText = OldphonePadTranslator.OldPhonePad(sequence);

        Console.WriteLine("Tranlated Text : ");
        Console.WriteLine(translatedText);
    }
}