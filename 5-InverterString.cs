string texto = "";
int i, tamanho;
Console.WriteLine("Digite uma string: ");
texto = Console.ReadLine();
tamanho = texto.Length;

Console.WriteLine("Sua string invertida: ");
for (i = tamanho; i > 0; i--)
{
    Console.Write("{0}", texto[i-1]);
}
