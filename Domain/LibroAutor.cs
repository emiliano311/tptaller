using System;
using TPFinal.Domain;
using System.ComponentModel.DataAnnotations;


namespace TPFinal.Domain
{
	public class LibroAutor
	{
		private Libro Libro { get; set; }
		public Autor Autor { get; set; }

		public LibroAutor(){ }
			
	}
	
}
