// See https://aka.ms/new-console-template for more information

Console.WriteLine("Inserisci il numero di cui vuoi calcolare il fattoriale");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Hai inserito il numero {0} ed il suo fattoriale è {1}", number, Factorial(number));
Console.ReadKey(true);

int Factorial(int number)
    {
        return Enumerable.Range(1, number).Aggregate((a, b) => a * b);
    }

