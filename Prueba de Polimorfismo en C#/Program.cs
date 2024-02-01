using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEnC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peugeot308 FCC321 = new Peugeot308("PEUGEOT");
            audiTT BCD251 = new audiTT("AUDI");

            
            
            
            
        }

    }

    class auto
    {
        public auto() 
        {
            this.marcaAuto = "DESCONOCIDA";
        }

        public auto(String marcaAuto)
        {

            this.marcaAuto = marcaAuto;

        }

        

        protected void encender()
        {
            Console.WriteLine("Se encendio el vehiculo");
        }

        public void apagar()
        {
            Console.WriteLine("Se apago el vehiculo");
        }

        public virtual void acelerar()
        {
            Console.WriteLine("Acelerando el vehiculo");
        }
        public void getMarcaAuto()
        {
            Console.WriteLine("La marca del auto es: " + marcaAuto);
        }

        private String marcaAuto;
    }

    class Peugeot308 : auto 
    {
        public Peugeot308(String marcaAuto) : base(marcaAuto)
        {

        }

        public void abrirTecho()
        {
            Console.WriteLine("Se abrio el vidrio del techo");
        }

        public override void acelerar()
        {
            Console.WriteLine("308 ACELERANDO");
            encender();
        }
 
    }

    class audiTT : auto
    {
        public audiTT(String marcaAuto) : base(marcaAuto)
        {

        }

        public void pensar()
        {
            Console.WriteLine("Acelerar con el auto descapotado");
        }

        public void abrirAleron()
        {
            Console.WriteLine("Se abrio el aleron");
        }

        public override void acelerar()
        {
            Console.WriteLine("AUDI TT ACELERANDO");
        }
    }

}
