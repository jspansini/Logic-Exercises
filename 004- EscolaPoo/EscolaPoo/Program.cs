using EscolaPoo.Models;

Pessoa primeiraPessoa = new Pessoa("Jessica", 32);
primeiraPessoa.Cumprimentar();
primeiraPessoa.DizerIdade();


Console.WriteLine("\n");
Console.WriteLine("----------------------------\n");

Aluno aluno = new Aluno("Erika", 16);
aluno.Cumprimentar();
aluno.DizerIdade();
aluno.IrParaEscola();


Console.WriteLine("\n");
Console.WriteLine("----------------------------\n");

Professor professor = new Professor("Mayke", 30);
professor.Cumprimentar();
professor.DizerIdade();
professor.ExplicarAssunto();

