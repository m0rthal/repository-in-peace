using System;

namespace Prueba
{
	public class Persona
	{
		private string nombre;
		private Int32 edad;
		private Int32 resultado;
		public Persona ()
		{
			this.nombre = "";
			this.edad = 0;
		}
		public Persona (string nom , Int32 ed)
		{
			this.nombre = nom;
			this.edad = ed;
		}
		public void setNombre (string nom)
		{
			this.nombre = nom;
		}
		public void setEdad (Int32 ed)
		{
			this.edad = ed;
		}
		public Int32 getResultado ()
		{
			return this.resultado;
		}
		public void formula (Int32 ed)
		{
			if (edad < 18)
				resultado = edad + ed;
			else if (edad > 18)
				resultado = edad - ed;
			else
				resultado = 0;
		}
	}
}

