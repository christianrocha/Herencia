using System;

namespace Herencia
{
	public class Alumno : Profesor{

		public string sexo;
		public string email;
		public string carrera;

		public void materias (){
			Console.WriteLine("Materias que llevo ");
			Console.WriteLine("\nArquitectura de Computo");
			Console.WriteLine("Estadistica Inferencial");
			Console.WriteLine("Base de Datos I");
			Console.WriteLine("Ingenieria de Software");
			Console.WriteLine("Modelado Matematico de Sistemas(Simulacion)");
			Console.WriteLine("Programacion III");
			Console.ReadLine();
		}

		public override String Datos(){

			return  "\nMi nombre es: " + this.nombre + " " + this.apellido + " " + 
					"\nTengo: " + this.edad + " años" + " " + 
					"\nSexo: " + this.sexo + " " +
					"\nEmail: " + this.email + " " + 
			"\nLa carrera que estudio es: " + this.carrera + " ";

        }
	}
}

