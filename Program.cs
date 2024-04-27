Console.WriteLine("CALCULADORA");

//Entrada de dados
Console.WriteLine("Escolha um número: ");
double num = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha outro número: ");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a operação: ");
string operaçao = Console.ReadLine();

//Processamento e saída de dados
double resultado = 0;
if (operaçao == "+")
{
    resultado = num + num2;
}
else if (operaçao == "-")
{
    resultado = num - num2;
}
else if (operaçao == "/")
{
   if (num2 == 0)
    {
        Console.WriteLine("O número não pode ser zero");
        return;
    }
   else
    {
        resultado = num / num2;
    }
}
else if (operaçao == "*")
{
    resultado = num * num2;
}

Console.WriteLine($"O resultado é de {resultado}");