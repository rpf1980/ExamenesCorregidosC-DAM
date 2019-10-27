using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
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

        static void Main(string[] args)
        {
            Complejo objeto1;
            Complejo objeto2;
            Complejo c = new Complejo();       

            //Variables para los atributos de los objetos de clase
            int real1=0, real2=0, imag1=0, imag2=0;

            int opcion = -1;
            while(opcion != 0)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("MENÚ OPCIONES CÁLCULOS NÚMEROS COMPLEJOS");
                Console.WriteLine("========================================");
                Console.WriteLine("[1] SUMA");
                Console.WriteLine("[2] MULTIPLICACIÓN");
                Console.WriteLine("[0] SALIR");
                Console.WriteLine();
                Console.Write("Opción ? = ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch(opcion)
                {
                    case 1:
                        {
                            //Pedimos datos
                            Console.Write("Número real 1 = ");
                            real1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Número imaginario 1 = ");
                            imag1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Número real 2 = ");
                            real2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Número imaginario 2 = ");
                            imag2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            //SUMAR
                            objeto1 = new Complejo(real1, imag1);
                            objeto2 = new Complejo(real2, imag2);
                            Complejo resultado1 = c.Suma(objeto1, objeto2);

                            string str = resultado1.Mostrar();
                            Console.WriteLine(str);
                        }
                        break;
                    case 2:
                        {
                            //Pedimos datos
                            Console.Write("Número real 1 = ");
                            real1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Número imaginario 1 = ");
                            imag1 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Número real 2 = ");
                            real2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Número imaginario 2 = ");
                            imag2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            //MULTIPLICAR
                            //Instanciamos los dos objetos que vamos a pasar
                            objeto1 = new Complejo(real1, imag1);
                            objeto2 = new Complejo(real2, imag2);

                            //Instanciamos otro objeto que llevará el resultado de la multiplicación
                            Complejo resultado2 = c.Multiplicar(objeto1, objeto2);

                            //Y mostramos el resultado por consola
                            string mostramos = resultado2.Mostrar();
                            Console.WriteLine(mostramos);
                        }
                        break;
                }
            }                    
            Console.ReadKey();
        }
    }
}
