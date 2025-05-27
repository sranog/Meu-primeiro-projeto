using System;

class Aluno
{
	public string Nome;
	public int[] Notas;

	public Aluno(string nome, int[] notas)
	{
		Nome = nome;
		Notas = notas;
	}
}

class Program
{
	static void Main()
	{
		Aluno[] turma = new Aluno[]
		{
			new Aluno("Ana Clara", new int[] {98, 97, 99, 96, 97}),
			new Aluno("Bruno Silva", new int[] {90, 92, 91, 93, 92, 85}),
			new Aluno("Camila Souza", new int[] {89, 88, 90, 87, 88, 95}),
			new Aluno("Diego Alves", new int[] {85, 87, 86, 84, 85, 90}),
			new Aluno("Eduarda Lima", new int[] {80, 82, 81, 83, 79, 80}),
			new Aluno("Felipe Santos", new int[] {78, 79, 77, 80, 76, 50}),
			new Aluno("Gabriela Ferreira", new int[] {74, 75, 76, 73, 72, 60}),
			new Aluno("Hugo Martins", new int[] {70, 72, 71, 69, 73, 40}),
			new Aluno("Isabela Costa", new int[] {68, 69, 67, 70, 66, 20}),
			new Aluno("João Pedro", new int[] {65, 67, 66, 64, 63, 30}),
			new Aluno("Karen Oliveira", new int[] {62, 63, 64, 61, 60, 50}),
			new Aluno("Lucas Ribeiro", new int[] {59, 60, 61, 58, 57, 60}),
			new Aluno("Mariana Almeida", new int[] {40, 45, 50, 55, 35, 100, 90})
		};

		Console.WriteLine("Aluno\t\tMédia\tNota final\tConceito\t Média(ponto extra)");

		foreach (Aluno aluno in turma)
		{
			int total = 0;
			decimal notasExtras = 0m;
			int provasObrigatorias = 5;

			for (int i = 0; i < aluno.Notas.Length; i++)
			{
				if (i < provasObrigatorias)
					total += aluno.Notas[i];
				else
					notasExtras += (decimal)aluno.Notas[i] / 10; // notas extras valem menos
			}

			int media = total / provasObrigatorias;
			decimal notasFinal = media + (decimal)notasExtras;
			string conceito = "";

			if (media >= 97)
				conceito = "A+";
			else if (media >= 93)
				conceito = "A";
			else if (media >= 90)
				conceito = "A-";
			else if (media >= 87)
				conceito = "B+";
			else if (media >= 83)
				conceito = "B";
			else if (media >= 80)
				conceito = "B-";
			else if (media >= 77)
				conceito = "C+";
			else if (media >= 73)
				conceito = "C";
			else if (media >= 70)
				conceito = "C-";
			else if (media >= 67)
				conceito = "D+";
			else if (media >= 63)
				conceito = "D";
			else if (media >= 60)
				conceito = "D-";
			else
				conceito = "F";

			Console.WriteLine($@"{aluno.Nome}\t\t{media}\t\t\t{notasFinal}\t{conceito}\t{media}({notasExtras})");
		}

		Console.ReadLine();
	}
}









			
