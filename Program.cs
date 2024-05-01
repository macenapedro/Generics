
Dictionary<int, Aluno> alunos = new()
{
    {1, new Aluno("Maria" , 7) },
    {2, new Aluno("Eric" , 8)},
    {3, new Aluno("Ana" , 9)},
    {4, new Aluno("Alex" , 6)},
    {5, new Aluno("Diná" , 5)}
};

Exibe(alunos);

do
{
    Console.WriteLine("\nInforme o indíce do aluno (99 sai)");
    int codigo = Convert.ToInt32(Console.ReadLine());

    if (codigo == 99)
        break;
    var resultado = alunos.ContainsKey(codigo);
    if (resultado)
    {
        Console.WriteLine("Informe a nota atualizada");
        var nota = Convert.ToInt32(Console.ReadLine());
        alunos[codigo].Nota = nota;
    } else
    {
        Console.WriteLine("Aluno não encontrado");
    }
} while (true);
Exibe(alunos);

Console.WriteLine("\nInforme o indíce do aluno a remover");
int cod = Convert.ToInt32(Console.ReadLine());
if (alunos.ContainsKey(cod))
{
    alunos.Remove(cod);
    Console.WriteLine("Aluno removido com sucesso!");
}
else
{
    Console.WriteLine("Chave inválida");
}
Exibe(alunos);

Console.WriteLine("\nIncluindo um novo aluno");
Console.WriteLine("Informe o nome do novo aluno");
string? novoNome = Console.ReadLine();

Console.WriteLine("Informe a nota do novo aluno");
int novaNota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o novo código do aluno");
int novoCodigo = Convert.ToInt32(Console.ReadLine());

if (!alunos.ContainsKey(novoCodigo))
{
    alunos.Add(novoCodigo, new Aluno(novoNome, novaNota));
} else
{
    Console.WriteLine("Código já existente");
};
Exibe(alunos);

Console.WriteLine("\nOrdenando os alunos por nome");
var alunosOrdenados = alunos.OrderBy(x => x.Value.Nome);

foreach(var aluno in alunosOrdenados)
{
    Console.WriteLine($"{aluno.Key} - {aluno.Value.Nome} - {aluno.Value.Nota}");
}
static void Exibe(Dictionary<int, Aluno> alunos)
{
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Key} - {aluno.Value.Nome} - {aluno.Value.Nota}");
    }
}

Console.WriteLine("\nLimpando a lista");
alunos.Clear();
Exibe(alunos);

Console.ReadKey();



class Aluno
{
    public Aluno(string? nome, int nota)
    {
        Nome = nome;
        Nota = nota;
    }
    public string? Nome { get; set; }
    public int Nota { get; set; }
}