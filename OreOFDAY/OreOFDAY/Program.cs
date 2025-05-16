Console.WriteLine("Bem Vindo A Calculadora!");

Console.WriteLine("Escolha Uma Operação +, -, *, /");
var operacao = Console.ReadLine();

(double, double) LerNumeros()
{
    Console.WriteLine("Digite o primeiro número:");
    var num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo número:");
    var num2 = Convert.ToDouble(Console.ReadLine());
    return (num1, num2);
}


switch (operacao)
{
    case "+":
        var (num1,num2) = LerNumeros();
        Console.WriteLine($"Resultado: {num1 + num2}");
        break;

    case "-":
        var (num3, num4) = LerNumeros();
        Console.WriteLine($"Resultado: {num3 - num4}");
        break;

    case "*":
        var (num5, num6) = LerNumeros();
        Console.WriteLine($"Resultado: {num5 * num6}");
        break;

    case "/":
        var (num7, num8) = LerNumeros();
        Console.WriteLine($"Resultado: {num7 / num8}");
        break;

}