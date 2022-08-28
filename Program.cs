using System;

class Program {
	// Desenvolvedor *** Gilson Caetano *** 
	// Projeto em Linguagem C# Compesa Abastecer com Gasolina / Álcool
	// Iniciante com C#
	public static void Main (string[] args) {
		double gasolina,etanol;
		string decisao = "";
		string texto;

	double posto= 0.7;
    string resultado;
	
    Console.Write("Digite o Usúario: ");
    string nome = Console.ReadLine();
	Console.Clear();

	while (decisao != "s" && decisao != "S")
		{
    texto = "Sejá Bem vindo ao simulado: " + (nome);
	texto = texto.ToUpper();
	Console.WriteLine(texto);
	
    Console.Write("Qual o valor da Gasolina: ");
    gasolina = double.Parse(Console.ReadLine());
    
    Console.Write("Qual o valor do Etanol: ");
    etanol = double.Parse(Console.ReadLine());
   
	double gas = 0.7 * gasolina;
    double eta = 0.7 * etanol;
		
    Console.WriteLine("Gasolina: {0:N2}",  gas );
    Console.WriteLine("Etanol: {0:N2}",  eta );

	posto=gasolina+etanol;

	 if((gasolina * 0.7) == eta){
       resultado="Tanto faz Gasolina ou Etanol. ";
    }else if((gasolina * 0.7) > eta){
		resultado="Compensa abastecer com Etanol.";
	}else{
		resultado="Compensa abastecer com Gasolina.";
	}
		
		Console.WriteLine("Resultado: "+ resultado);
	
		Console.Write("Deseja Encerrar Pressione S / N: ");
		decisao = Console.ReadLine();
		Console.Clear();

			}
		
		}
		
	}