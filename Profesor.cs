using System;

namespace Herencia
{
	public class Profesor{
		public string nombre;
		public string apellido;
		public int edad;

		public Profesor (){
			this.nombre = "";
			this.apellido = "";
			this.edad = 0;
		}
		
		public virtual String Datos(){

			return 
				"Nombre: " + this.nombre + "\n" +
					"Apellido: " + this.apellido + "Edad: " + this.edad;
		}
	}
}

