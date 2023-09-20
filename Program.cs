using ExemploExplorando.Models;
using Microsoft.Win32.SafeHandles;


int numero = 15;
bool ehPar = false;

//IF Ternario
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


















// Pessoa p1 = new Pessoa();
// p1.Nome = "José";
// p1.Sobrenome = "Emerson";

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoleitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//     foreach (string linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }






















// (int, string, string) tupla = (1, "Emerson", "Silva");

// Console.WriteLine(tupla.Item1);












// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "Sao Paulo");
// estados.Add("BA", " Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("BA");



















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
//}
























//new ExemploExcecao().Metdodo1();























// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui")
// }














// Pessoa p1 = new(nome: "Emerson", sobrenome: "Silva");
// Pessoa p2 = new(nome: "Eduardo", sobrenome: "Neves");

// // Pessoa p1 = new Pessoa();
// // Pessoa p2 = new Pessoa();

// // p1.Nome = "Emerson"; p1.Sobrenome = "Silva";
// // p2.Nome = "Eduardo"; p2.Sobrenome = "Neves";


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();













// Pessoa p1 = new();

// p1.Nome = "Emerson";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;
// p1.Apresentar();
