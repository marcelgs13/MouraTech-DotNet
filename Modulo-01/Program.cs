//Exercício 1: Hello World Evoluído (Saída de Dados)
Console.WriteLine("=======================");
Console.WriteLine("CURSO DE C# E .NET");
Console.WriteLine("Meu primeiro programa em C#");
Console.WriteLine("=======================");

//Exercício 2: Interação e Entrada de Usuário
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome}!");

Console.WriteLine("=======================");

//Mini-Desafio: Desenvolva um programa que solicite Nome, Cidade e Profissão. A saída deve 
//respeitar rigorosamente a formatação em múltiplas linhas:Saída Esperada:Olá Nome!Você mora em
// Cidade e trabalha como Profissão.
Console.Write("Digite seu nome: ");
string nome2 = Console.ReadLine();
Console.Write("Digite sua cidade: ");
string cidade = Console.ReadLine();
Console.Write("Digite sua profissão: ");
string profissao = Console.ReadLine();
Console.WriteLine($"Olá {nome2}!\nVocê mora em {cidade} e trabalha como {profissao}.");

Console.WriteLine("=======================");

//Exercício 3: Operações Matemáticas e Conversão
Console.Write("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());
double soma = numero1 + numero2;
Console.WriteLine($"Resultado: {soma}");

Console.WriteLine("=======================");

//Exercício 4: Consolidação (Conversor de Temperatura)

Console.Write("Digite a temperatura em Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}");

Console.WriteLine("=======================");

//Desafio Final do Módulo: Cálculo de Média
Console.Write("Informe o nome do aluno: ");
string nomeAluno = Console.ReadLine();
Console.Write("Informe a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
int quantidadeNotas = 2;
double media = (nota1 + nota2) / quantidadeNotas;
string status;
if (media >= 7)
{
    status = "APROVADO";
}
else
{
    status = "REPROVADO";
}
Console.WriteLine("O aluno " + nomeAluno + " tem média " + media + " e está " + status);

Console.WriteLine("=======================");