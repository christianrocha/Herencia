using System;

namespace Herencia
{
	public class Principal{

		public void alumno ()
		{
			Alumno alumno = new Alumno ();

			alumno.nombre = "Christian Alejandro";
			alumno.apellido = "Rocha Martinez";
			alumno.sexo = "Masculino";
			alumno.edad = 19;
			alumno.email = "christian_tachi@hotmail.com";
			alumno.carrera = "Ingenieria en Ciencias Computacionales";
			alumno.materias();		

			Profesor profesor = alumno;
			Console.WriteLine (profesor.Datos ());

		}
		public static void Main (string[] args)
		{
			Principal imprimir = new Principal();
			
			imprimir.alumno();
			
		}
	}
}