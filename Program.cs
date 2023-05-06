
/*
Oppgave 1: 

Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger

-------------------------------------------------------------

Oppgave 2:

Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen

Hint: en string kan brukes på samme måte som et array!

---------------------------------------------------------------

Oppgave 3:

Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10

Eks:

Runde nr 1

Runde nr 2

Runde nr 3
*/



namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            forLoop();
            forEach();
            While();
        }

        static void forLoop() // Oppg 1
        {
            Console.WriteLine("Oppgave 1:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul " + i);
            }
        }

        static void forEach() // Oppg 2
        {
            string myText = "hei på deg";
            
            Console.WriteLine("Oppgave 2:");

            foreach(var letter in myText)
            {
                Console.WriteLine(letter);
            }
        }

        static void While()
        {
            Console.WriteLine("Oppgave 3:");
            bool shouldContinue = true;
            int i = 0;

            while(shouldContinue)
            {
                if(i<10)
                {
                    Console.WriteLine("Runde nr. " + i++);
                }
                
            }
        }
    }
}