string[,] faltas = new string[2, 3];
string opcao;
int l, c;
double presenca;
double hora = 0;

l = 0;
c = 0;

for (l = 0; l <= 1; l++)
{
    Console.WriteLine("informe o numero da UC:");
    faltas[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a descrição da UC:");
    faltas[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a carga horaria da UC:");
    faltas[l, c++] = Console.ReadLine();

    c = 0;
}

Console.WriteLine("Qual a duração de sua aula diária:");
hora = double.Parse(Console.ReadLine());

for (l = 0; l <=1; l++)
{
    presenca = (double.Parse(faltas[l, 2]) * 0.25) / hora;
    Console.WriteLine("A quantidade de faltas que voce pode ter é: " + presenca);

}