string[,] faltas = new string[2, 3];
string opcao;
int l, c;
double presenca;

l = 0;
c = 0;

for (l = 0; l <= 2; l++)
{
    Console.WriteLine("informe o numero da UC:");
    faltas[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a descrição da UC:");
    faltas[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a carga horaria da UC:");
    faltas[l, c++] = Console.ReadLine();

    c = 0;
}

for (l = 0; l <=2; l++)
{
    presenca = 
}