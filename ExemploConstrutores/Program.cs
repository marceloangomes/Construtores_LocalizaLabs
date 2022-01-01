// See https://aka.ms/new-console-template for more information


using ExemploConstrutores.Model;

Pessoa p1 = new Pessoa("Patricia", "Gomes");

p1.Apresentar();

var log1 = Log.GetInstance();
log1.PropriedadeLog = "Somente uma vez";
var log2 =Log.GetInstance();
System.Console.WriteLine(log2.PropriedadeLog);

Aluno a1 = new Aluno("Marcelo", "Gomes", "Matematica");
a1.Apresentar();



var op = new Operacao(Calculadora.Somar);
op+=Calculadora.Subtrair;
op.Invoke(10,10);

Matematica m = new Matematica(30,20);
m.Somar();

public delegate void Operacao(int x, int y);










