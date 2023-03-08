string[,] faltas = new string[2, 3];
int opcao = 0; ;
int l, c;
double presenca;
double hora = 0;
string pesquisar = "";
string busca = "";
string voltar = "sim";

l = 0;
c = 0;

while (voltar == "sim" || voltar == "SIM") {

    Console.WriteLine("Digite 1 para cadastrar");
    Console.WriteLine("Digite 2 para pesquisar a quantidade de faltas");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        case 1:
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

            break;

        case 2:
            Console.WriteLine("Qual a duração de sua aula diária:");
            hora = double.Parse(Console.ReadLine());

            for (l = 0; l <= 1; l++)
            {
                pesquisar = "SIM";
                while (pesquisar == "SIM" || pesquisar == "sim")
                {

                    Console.WriteLine("Qual a duração de sua aula diária:");
                    hora = double.Parse(Console.ReadLine());

                    presenca = (double.Parse(faltas[l, 2]) * 0.25) / hora;                   

                    Console.WriteLine("UC que deseja pesquisar");
                    busca = Console.ReadLine();

                    for (l = 0; l <= 1; l++)
                    {
                        if (busca == faltas[l, 0])
                        {
                            Console.WriteLine("Na " + faltas[l, 0] + "" + faltas[l, 1] + " A quantidade de faltas que voce pode ter é: " + presenca);

                        }
                    }


                    Console.WriteLine("Deseja pesquisar a quantidade de faltas em outra UC");
                    pesquisar = Console.ReadLine();
                }
            }
            break;

        default:

            break;


    }
    
    Console.WriteLine("Deseja voltar para CADASTRAR ou PESQUISAR");
    voltar = Console.ReadLine();
}