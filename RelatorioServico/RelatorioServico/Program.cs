// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Informacoes Diarias
string dataHoraCorrida_Diario;
string dataHoraEmissaoRelatorio_Diario;
double kmInicial_Diario;
double kmFinal_Diario;
double kmTotalRodado_Diario;
string nomeEmpresaSolicitante_Diario;
string observacoes_Diario;
string modeloCarro_Diario;


// Listas
string nomeClientes_Diario;
string listaEnderecoEntrada_Diario;
string listaEnderecoSaida_Diario;


Console.WriteLine("Insira abaixo as informações de relatório diario:");

Console.WriteLine($"1 - Dia e Horário da corrida");
dataHoraCorrida_Diario = Console.ReadLine();

Console.WriteLine($"2 - KM Inicial:");
kmInicial_Diario = Convert.ToInt64(Console.ReadLine());

Console.WriteLine($"3 - KM Final");
kmFinal_Diario = Convert.ToInt64(Console.ReadLine());

kmTotalRodado_Diario = kmInicial_Diario - kmFinal_Diario;

Console.WriteLine($"4 - Empresa Solicitante para o dia");
nomeEmpresaSolicitante_Diario = Console.ReadLine();

Console.WriteLine($"5 - Observacoes: ");
observacoes_Diario = Console.ReadLine();

Console.WriteLine($"6 - Modelo do carro utilizado: ");
modeloCarro_Diario = Console.ReadLine();

// Adicionar um loop para solicitar nome de cada passageiro e outras infos se precisar
Console.WriteLine($"7 - Insira a quantidade (numero) de clientes que utilizaram a van: ");
nomeClientes_Diario = Console.ReadLine();

//Adicionar um loop
Console.WriteLine($"8 - Insira endereco da corrida: ");
listaEnderecoEntrada_Diario = Console.ReadLine();

//Adicionar um loop
Console.WriteLine($"9 - Endereco de saida: ");
listaEnderecoSaida_Diario = Console.ReadLine();


Console.WriteLine($"------- FIM -----------");




dataHoraEmissaoRelatorio_Diario = Convert.ToString(DateTime.Now);


