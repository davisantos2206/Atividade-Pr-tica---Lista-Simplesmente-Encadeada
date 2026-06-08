public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Telefone { get; set; }
    public decimal Salario { get; set; }

    public Funcionario(string nome, int idade, string telefone, decimal salario)
    {
        Nome = nome;
        Idade = idade;
        Telefone = telefone;
        Salario = salario;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Salario: {Salario:C}");
    }
}
