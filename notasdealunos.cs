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
			new Aluno("Sara", new int[] {100, 89, 95, 80, 87, 95, 88, 100}),
			new Aluno("Lucas", new int[] {75, 82, 90, 88}),
			new Aluno("Mariana", new int[] {60, 70, 65, 72, 68}),
			new Aluno("João", new int[] {95, 93, 90, 98, 97, 92}),
			new Aluno("Ana", new int[] {55, 60, 58}),
			new Aluno("Pedro", new int[] {85, 88, 84, 87, 86, 89, 90}),
			new Aluno("Camila", new int[] {78, 80, 76}),
			new Aluno("Rafael", new int[] {100, 100, 100, 100}),
			new Aluno("Beatriz", new int[] {45, 50, 48, 52, 47, 49, 46}),
			new Aluno("Carlos", new int[] {67, 72, 70}),
			new Aluno("Letícia", new int[] {90, 85, 88, 92, 87, 89, 91, 86, 90, 93})
		};

		Console.WriteLine("Aluno\t\tMédia\tConceito\n");

		foreach (Aluno aluno in turma)
		{
			int total = 0;
			int provasObrigatorias = 5;

			for (int i = 0; i < aluno.Notas.Length; i++)
			{
				if (i < provasObrigatorias)
					total += aluno.Notas[i];
				else
					total += aluno.Notas[i] / 10; // notas extras valem menos
			}

			int media = total / provasObrigatorias;
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

			Console.WriteLine($"{aluno.Nome}\t\t{media}\t{conceito}");
		}

		Console.ReadLine();
	}
}









			
