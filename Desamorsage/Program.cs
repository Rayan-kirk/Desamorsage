using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int codeSecret = rand.Next(1, 21); // de 1 à 20 inclus
        int tentative;

        do
        {
            Console.Write("Entrez votre tentative de code (1-20) : ");
            tentative = int.Parse(Console.ReadLine());

            if (tentative < codeSecret)
                Console.WriteLine("[ALERTE] Code trop bas ! Accès restreint.");
            else if (tentative > codeSecret)
                Console.WriteLine("[ALERTE] Code trop haut ! Surcharge détectée.");
            else
                Console.WriteLine("[SUCCÈS] Porte déverrouillée, bon travail agent");

        } while (tentative != codeSecret);
    }
}