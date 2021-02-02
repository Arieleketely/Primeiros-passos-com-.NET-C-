using System;
using Classes.Herança;
//não esquecer o namespace para instanciar
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
          //Instanciando classe nova ESTATICA
          Ponto p1= new Ponto(10,20);
         Ponto3D p2= new Ponto3D(10,20,30);

         Ponto3D.Calcular();

        }
    }
}
