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
        public Pelicula(){}
        public Pelicula(string titulo, Int16 año)
        {
            this.Titulo=titulo;
            this.Año=año;
        }
     
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
        
        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);
        }

        public void ImprimeActores()
        {
            foreach (Actor persona in actores)
            {
                Console.WriteLine($"{persona.GetNombre()} ({persona.GetAño()})");
            }

        }

        
        
        



    }

    public class Actor
    {
        //Propiedades
        public string Nombre;
        public Int16 Año;
       

        //Constructores
        public Actor(){}
        public Actor(string Nombre , Int16 Año)
        {
            this.Nombre=Nombre;
            this.Año=Año;
        }
        


        //Métodos 

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public Int16 GetAño()
        {
            return Año;
        }

        public void SetAño(Int16 Año)
        {
            this.Año = Año;
        }
        
        
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
            p1.AgregaActor(new Actor ("Bredan Fraser", 1968));
            p1.AgregaActor(new Actor("Sadie Sink", 2002));
            p2.AgregaActor(new Actor("Goku", 737));
            p2.AgregaActor(new Actor("Vegeta", 732 ));
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño() );
            Console.WriteLine("{0}({1})", p2.GetTitulo(), p2.GetAño() );

            p1.ImprimeActores();
            p2.ImprimeActores();

            List<Pelicula> peluculaschidas = new List<Pelicula>();
            peluculaschidas.Add(new Pelicula("chucky", 1988 ));
            peluculaschidas.Add(new Pelicula("chucky 2", 1990 ));
            peluculaschidas.Add(new Pelicula("chucky 3", 1991 ));
            peluculaschidas.Add(new Pelicula("La novia del chucky ", 1998 ));
            peluculaschidas.Add(new Pelicula("El Hijo de Chucky", 2004 ));

            foreach(Pelicula chuckys in peluculaschidas)
            {
                chuckys.Imprime();
            }            
        }
    }
}
