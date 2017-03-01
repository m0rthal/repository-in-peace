using System;
using Prueba;

namespace Prueba
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Persona usuario;
			string nombre;
			Int32 edad;
			Int32 numero;
			Console.WriteLine ("Hola Mundo!");
			Console.WriteLine ("\nAqui dejo una pequena prueba");
			Console.WriteLine ("\n\n");
			Console.Write ("Ingrese nombre: ");
			nombre = Console.ReadLine ();
			Console.Write ("Ingrese edad: ");
			edad = Int32.Parse (Console.ReadLine ());
			Console.Write ("Ingrese numero aleatorio: ");
			numero = Int32.Parse (Console.ReadLine ());
			usuario = new Persona (nombre, edad);
			usuario.formula (numero);
			Console.WriteLine ("\n");
			Console.Write ("El resultado final es: ");
			Console.WriteLine (usuario.getResultado ());
		}
	}
}
