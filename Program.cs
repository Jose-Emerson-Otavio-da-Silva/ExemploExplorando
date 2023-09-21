using ExemploExplorando.Models;
using Newtonsoft.Json;



int numero = 20;
bool par = false;

// IF Ternário
par = numero.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);
















// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdcionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdcionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);












// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

















// string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }










// var tipoAnonimo = new { Nome = "José", Sobrenome = "Emerson", Altura = 1.80 };

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");












// string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, "
//         + $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy")}"
//         + $"{(venda.Desconto.HasValue ? $", Desconto de: {venda.Desconto}" : "")}");
// }














// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value){
//     Console.WriteLine("Usuário optou por receber email.");
// }
// else{
//     Console.WriteLine("Usuário optou por não receber email");
// }






































// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/Vendas.json", serializado);

// Console.WriteLine(serializado);












// int numero = 15;
// bool ehPar = false;

// //IF Ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


















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
