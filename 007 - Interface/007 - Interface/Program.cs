

using _007___Interface.Models.Animais;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Exercicio de aplicação de interfaces\n");

Arara ararinha = new Arara();
ararinha.Botar();

Cisne cisne = new Cisne();
cisne.Voar();

Ornitorrinco ornitorrinco = new Ornitorrinco();
ornitorrinco.TodosOsMetodos();

Elefante elefante = new Elefante();
elefante.Pelos = true;

Leao leao = new Leao();
leao.Rugido();