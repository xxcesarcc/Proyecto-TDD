using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_ADM.Clases
{
    public static class Repositorio
    {
        // CREACION DE OBJETOS TIPO VASO SEGUNDO EL TAMANO
        // SE LES ASIGNAN UN VALOR POR DEFECTO.
        public static Vaso VasoP = new() { CantidadVasos = 5 };
        public static Vaso VasoM = new() { CantidadVasos = 6 };
        public static Vaso VasoG = new() { CantidadVasos = 7 };

        // CREACION DE VARIABLE TIPO AZUCARERO.
        public static Azucarero Azucar = new();

        // CREACION DE VARIABLE TIPO CAFETERA.
        public static Cafetera Cafe = new();


        // **********************- VASO PEQUENO -******************************
        public static bool HasGiveVasoPequeno(int Cantidad)
        {
            // CONDICIONAL QUE VERIFICA QUE LA CANTIDAD DE VASOS INGRESADA
            // POR EL USUARIO NO SEA MAYOR A LOS VASOS EN EXISTENCIA, SI 
            // SE CUMPLE RETORNARA FALSO.
            bool Condicion = Cantidad > VasoP.CantidadVasos ? false : true;

            // SI ES VERDADERA PUES SE RESTARA EL NUMERO DE VASOS Y DEVOLVERA
            // UN TRUE.

            if (Condicion)
            {
                // RESTAR LA CANTIDAD DE VASOS EN EXISTENCIA.
                VasoP.CantidadVasos -= Cantidad;

                return true;
            }
            else
            {
                return false;
            }
        }

        // **********************- VASO GRANDE -******************************
        public static bool HasGiveVasoGrande(int Cantidad)
        {
            // CONDICIONAL QUE VERIFICA QUE LA CANTIDAD DE VASOS INGRESADA
            // POR EL USUARIO NO SEA MAYOR A LOS VASOS EN EXISTENCIA, SI 
            // SE CUMPLE RETORNARA FALSO.
            bool Condicion = Cantidad > VasoG.CantidadVasos ? false : true;

            // SI ES VERDADERA PUES SE RESTARA EL NUMERO DE VASOS Y DEVOLVERA
            // UN TRUE.

            if (Condicion)
            {
                // RESTAR LA CANTIDAD DE VASOS EN EXISTENCIA.
                VasoG.CantidadVasos -= Cantidad;

                return true;
            }
            else
            {
                return false;
            }
        }

        // **********************- VASO MEDIANO -******************************
        public static bool HasGiveVasoMediano(int Cantidad)
        {
            // CONDICIONAL QUE VERIFICA QUE LA CANTIDAD DE VASOS INGRESADA
            // POR EL USUARIO NO SEA MAYOR A LOS VASOS EN EXISTENCIA, SI 
            // SE CUMPLE RETORNARA FALSO.
            bool Condicion = Cantidad > VasoM.CantidadVasos ? false : true;

            // SI ES VERDADERA PUES SE RESTARA EL NUMERO DE VASOS Y DEVOLVERA
            // UN TRUE.

            if (Condicion)
            {
                // RESTAR LA CANTIDAD DE VASOS EN EXISTENCIA.
                VasoM.CantidadVasos -= Cantidad;

                return true;
            }
            else
            {
                return false;
            }
        }

        // **********************- CANTIDAD DE CAFE -******************************
        public static bool CantidadCafe(int Cantidad)
        {
            // VARIABLE QUE MULTIPLICARA LA CANTIDAD DE AZUCAR POR UN DECIMAL
            // PARA RESTAR LA CANTIDAD DEL CAFE.
            double CantidadC = (0.1 * Cantidad) * 0.50;

            // SE MULTIPLICA LA CANTIDAD DE CUCHARADAS POR LA CANTIDAD DE VASOS.
            CantidadC *= Cantidad;

            bool Condicion = CantidadC > Cafe.cantidadCafe ? false : true;

            // SI ES VERDADERA PUES SE RESTARA LA CANTIDAD DE CAFE Y DEVOLVERA
            // UN TRUE.

            if (Condicion)
            {
                Cafe.cantidadCafe -= CantidadC;

                return true;
            }
            else
            {
                return false;

            }
        }

        // **********************- CANTIDAD DE AZUCAR -******************************
        public static string CantidadAzucar(int Cantidad, int CantVasos)
        {
            // VARIABLE QUE MULTIPLICARA LA CANTIDAD DE AZUCAR POR UN DECIMAL
            // PARA RESTAR LA CANTIDAD DE AZUCAR.
            double CantidadA = (0.1 * Cantidad) * 0.50;

            // SE MULTIPLICA LA CANTIDAD DE CUCHARADAS POR LA CANTIDAD DE VASOS.
            CantidadA *= CantVasos;

            bool Condicion = CantidadA > Azucar.cantidadDeAzucar ? false : true;

            // SI ES VERDADERA PUES SE RESTARA EL NUMERO DE VASOS Y DEVOLVERA
            // UN TRUE.

            if (Condicion)
            {

                Azucar.cantidadDeAzucar -= CantidadA;

                return "Recoge el vaso";
            }
            else
            {
                return "No hay azúcar para la cantidad de vasos.";

            }
        }

        // **************- INGRESAR VASOS SEGUN EL TIPO -**************
        public static void IngresarVasos(int Opcion, int Cantidad)
        {
            /*
             > SI OPCION ES IGUAL A 1 SIGNIFICA QUE ES UN VASO PEQUEÑO.
             > SI OPCION ES IGUAL A 2 SIGNIFICA QUE ES UN VASO MEDIANO.
             > SI OPCION ES IGUAL A 3 SIGNIFICA QUE ES UN VASO GRANDE.          
             */

            // VARIABLE QUE ALMACENA UN MENSAJE.
            string Error = "No hay vasos suficientes.";

            // SWITCH QUE CONTIENE LAS OPCIONES.


            switch (Opcion)
            {
                case 1:

                    // BOOL QUE ALMACENA EL RETORNO DEL METODO.
                    var Bool = HasGiveVasoPequeno(Cantidad);

                    if (Bool)
                    {
                        // SI BOOL ES TRUE, INSERTAR EL RESULTADO EN OPERACIONES.
                        Operaciones(Bool, Cantidad);
                    }
                    else
                    {
                        // MENSAJE DE ERROR.
                        Console.WriteLine(Error);
                        Console.WriteLine("Presione enter para volver al menú.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;

                case 2:

                    // BOOL QUE ALMACENA EL RETORNO DEL METODO.
                    Bool = HasGiveVasoMediano(Cantidad);

                    // SI BOOL ES TRUE, INSERTAR EL RESULTADO EN OPERACIONES.
                    if (Bool)
                    {
                        Operaciones(Bool, Cantidad);
                    }
                    else
                    {
                        // MENSAJE DE ERROR.
                        Console.WriteLine(Error);
                        Console.WriteLine("Presione enter para volver al menú.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;

                case 3:

                    // SI BOOL ES TRUE, INSERTAR EL RESULTADO EN OPERACIONES.
                    Bool = HasGiveVasoGrande(Cantidad);

                    // SI BOOL ES TRUE, INSERTAR EL RESULTADO EN OPERACIONES.
                    if (Bool)
                    {
                        Operaciones(Bool, Cantidad);
                    }
                    else
                    {
                        // MENSAJE DE ERROR.
                        Console.WriteLine(Error);
                        Console.WriteLine("Presione enter para volver al menú.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;

                default:
                    Console.WriteLine("La opción es incorrecta.");
                    Console.WriteLine("Presione enter para volver al menú.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        // **************- OPERACIONES PARA INGRESAR LAS CUCHARADAS DE AZUCAR -**************
        public static void Operaciones(bool Bool, int CantVasos)
        {
            // SI EL METODO RECIBE UN TRUE, ENTONCES SE INGRESARAN LAS CUCHARADAS.
            if (Bool)
            {
                bool Result = CantidadCafe(CantVasos);

                if (Result)
                {
                    Console.WriteLine("Ingrese la cantidad de cucharitas de azúcar");
                    int Cant = int.Parse(Console.ReadLine());

                    // LIMPIAR PANTALLA.
                    Console.Clear();

                    // VARIABLE QUE ALMACENA EL MENSAJE QUE RETORNA EL METODO.
                    string Mensaje = CantidadAzucar(Cant, CantVasos);

                    // IMPRIMIR MENSAJE...
                    Console.WriteLine(Mensaje);
                    Console.WriteLine("Presione enter para volver al menú.");
                    Console.ReadKey();
                    Console.Clear();

                }
                // SI RECIBE UN FALSE ENTONCES LA CANTIDAD DE VASOS EXCEDIO EL LIMITE.
                else
                {
                    Console.WriteLine("La cantidad de vaso es mayor a la existencia.");
                    Console.WriteLine("Presione enter para volver al menú.");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
            else
            {
                Console.WriteLine("No hay suficiente café para su solicitud");
                Console.WriteLine("Presione enter para volver al menú.");
                Console.ReadKey();
                Console.Clear();
            }

        }

    }


}
