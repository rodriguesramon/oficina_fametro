string nome;
int idade;
double pretensao_salarial;

Console.WriteLine("Informe o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Informe a idade: ");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Pretensão Salarial: ");
pretensao_salarial = double.Parse(Console.ReadLine());

// var texto_final = "Nome: " + nome + ", Idade: " + idade + ", Pretensão Salarial: " + pretensao_salarial;
var texto_final = $"Nome: {nome}, Idade: {idade}, Pretensão: {pretensao_salarial}";

Console.WriteLine(texto_final);

