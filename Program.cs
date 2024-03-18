//Programa feito no Visual Studio 2022, C#.
int procurar;

Console.WriteLine("Digite um número: ");
procurar = int.Parse(Console.ReadLine());

if (PertenceFibonacci(procurar))
    Console.WriteLine("O número {0} está presente na sequência de Fibonacci", procurar);
else
    Console.WriteLine("O número {0} não está presente na sequência de Fibonacci", procurar);


//Calcula a sequência de Fibonacci
int Fibonacci(int tamanhoSequencia)
{
    if (tamanhoSequencia == 1 || tamanhoSequencia == 0)
        return tamanhoSequencia;
    else
        return Fibonacci(tamanhoSequencia - 2) + Fibonacci(tamanhoSequencia - 1);
}

//Verifica se o número está presente na sequência de Fibonacci
bool PertenceFibonacci(int numeroBuscado)
{
    int argumentoFibonacci;
    int retornoFibonacci;

    argumentoFibonacci = 0;
    while (1 == 1)
    {
        retornoFibonacci = Fibonacci(argumentoFibonacci);
        if (numeroBuscado == retornoFibonacci)
            return true;
        else if (numeroBuscado < retornoFibonacci)
            return false;
        argumentoFibonacci++;
    }
}
