using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Complejo
    {
        //Atributos
        private int parteReal;
        private int parteImaginaria;

        //Constructores
        public Complejo() { }

        public Complejo(int parteReal, int parteImaginaria)
        {
            this.parteReal = parteReal;
            this.parteImaginaria = parteImaginaria;
        }

        //Getter && Setter
        public int GetPartedReal()
        {
            return this.parteReal;
        }
        public void SetParteReal(int parteReal)
        {
            this.parteReal = parteReal;
        }

        public int GetParteImaginaria()
        {
            return this.parteImaginaria;
        }
        public void SetParteImaginaria(int parteImaginaria)
        {
            this.parteImaginaria = parteImaginaria;
        }

        //Métodos
        public string Mostrar()
        {
            return $"{GetPartedReal()} + {GetParteImaginaria()}i";
        }

        public Complejo Suma(Complejo objeto1, Complejo objeto2)
        {
            int res1, res2;

            //Guardamos los datos de las propiedades del los objetos de la clase Complejo
            res1 = objeto1.GetPartedReal() + objeto2.GetPartedReal(); //Parte real
            res2 = objeto1.GetParteImaginaria() + objeto2.GetParteImaginaria(); //Parte imaginaria              

            Complejo resultadoSuma = new Complejo(res1, res2);

            return resultadoSuma;
        }

        public Complejo Multiplicar(Complejo objeto1, Complejo objeto2)
        {

            int real1, real2, img1, img2;
            int a, b, c, d;
            int res1, res2;

            //Guardamos los datos de las propiedades del los objetos de la clase Complejo
            real1 = objeto1.GetPartedReal();
            img1 = objeto1.GetParteImaginaria();
            real2 = objeto2.GetPartedReal();
            img2 = objeto2.GetParteImaginaria();

            a = real1 * real2;
            b = real1 * img2;
            c = img1 * real2;
            d = img1 * img2;

            res1 = a + (-d); //Esto sería parte real
            res2 = b + c; //Esto sería parte imaginaria

            //Asignamos los nuevos parámetros del objeto que devolvemos
            Complejo resultadoMultiplicacion = new Complejo(res1, res2);

            return resultadoMultiplicacion;
        }
    }
}
