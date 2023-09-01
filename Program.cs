﻿using ExemploExplorando.Models;
using Microsoft.Win32.SafeHandles;



Pessoa p1 = new();
p1.Nome = "Emerson";
p1.Sobrenome = "Silva";

Pessoa p2 = new();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();













// Pessoa p1 = new();

// p1.Nome = "Emerson";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;
// p1.Apresentar();
