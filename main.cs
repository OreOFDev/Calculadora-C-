// Printei bem vindo :D
Console.WriteLine("Bem Vindo A Calculadora!");

// pedi para a pessoa escolher uma operacao e guardei numa variavel que e a operacao
Console.WriteLine("Escolha Uma Operacao +, -, *, /");
string operacao = Console.ReadLine();

// criei uma funcao que pra cada operacao pede dois numeros e retorna eles pra eu economizar linhas dps
(double, double) Digitar()
{
    Console.WriteLine("Digite o primeiro numero:");
    var num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero:");
    var num2 = Convert.ToDouble(Console.ReadLine());
    return (num1, num2);
}

// aqui eu uso o switch pra ver qual operacao a pessoa escolheu e chamo a funcao que pedi os numeros
// nao comentei muito dessa vez tbm pq e tudo igual so muda a operacao :D
switch (operacao)   
{
    case "+":
        var (num1, num2) = Digitar();
        var resultadoSoma = num1 + num2;
        Console.WriteLine($"Resultado: {resultadoSoma}");
        break;

    case "-":
        var (num3, num4) = Digitar();
        var resultadoSubtracao = num3 - num4;
        Console.WriteLine($"Resultado: {resultadoSubtracao}");
        break;

    case "*":
        var (num5, num6) = Digitar();
        var resultadoMultiplicacao = num5 * num6;
        Console.WriteLine($"Resultado: {resultadoMultiplicacao}");
        break;

    case "/":
        var (num7, num8) = Digitar();
        var resultadoDivisao = num7 / num8;
        Console.WriteLine($"Resultado: {resultadoDivisao}");
        break;
}

// Meu primeiro projeto em C# faz o L
