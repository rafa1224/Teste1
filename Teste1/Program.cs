
Console.WriteLine("digite a nota do primeiro semestre");

float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a nota do segundo semestre");

float nota2 = float.Parse(Console.ReadLine());


float resultado = (nota1+nota2)/2;

Console.WriteLine("sua media é de {0:N}\n", resultado);

