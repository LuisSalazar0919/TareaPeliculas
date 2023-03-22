using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string Titulo;
        private Int16 Año;
        private string Pais;
        private string director; 





        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public Int16 GetAño()
        {
            return Año;
        }

        public void SetAño(Int16 año)
        {
            this.Año = año;
        }
        
        public string GetPais()
        {
            return Pais;
        }

        public void SetPais(string Pais)
        {
            this.Pais = Pais;
        }

        public string GetDirector()
        {
            return director;
        }
        
        public void SetDirector(string director)
        {
            this.director = director;
        }
     
        public void Imprime()
        {
          Console.WriteLine($"{Titulo} ({Año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
           //  Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            Pelicula p2 = new Pelicula();
            p1.SetTitulo("the whale");
            p1.SetAño(2022);
            p2.SetTitulo("goku vs broly");
            p2.SetAño(2018);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño() );
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño() );
        }
    }
}
