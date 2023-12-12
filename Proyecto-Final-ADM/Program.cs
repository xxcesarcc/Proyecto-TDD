
using Proyecto_Final_ADM.Clases;
using System.Diagnostics.Contracts;

public class Maquina_de_Cafe
{
    public static void Main(string[] args)
    {
        // VARIABLE DE LA CLASE REPOSITORIO.


        // DECLARACION DE VARIABLES.
        int Opcion;
        int Cantidad;

        do
        {
            // MENU DE OPCIONES
            Console.WriteLine(@"
**********************************************************
********* Bienvenido a TuCafé, elija una opción. *********
**********************************************************

1. Vaso pequeño -> 3 Oz de café.
2. Vaso Mediano -> 5 Oz de café.
3. Vaso Grande -> 7 Oz de café.
4. Salir

");
            // ELEGIR UNA OPCION
            Console.Write("Opción: ");
            Opcion = int.Parse(Console.ReadLine());

            // SI LA OPCION ES MAYOR A 4 O MENOR IGUAL A CERO PUES EL
            // PROGRAMA SE CERRARA.
            if (Opcion >= 4 || Opcion <= 0)
            {
                Environment.Exit(0);
            }

            // SOLICITAR LA CANTIDAD DE VASOS.
            Console.Write("\nIngrese la cantidad: ");
            Cantidad = int.Parse(Console.ReadLine());

            // LIMPIAR PANTALLA
            Console.Clear();

            // INGRESAR LA CANTIDAD DE VASOS Y LA OPCION ELEGIDA PARA
            // DETERMINA EL TIPO DE VASO Y BUSCAR LA EXISTENCIA DEL TIPO
            // ESPECIFICADO.
            Repositorio.IngresarVasos(Opcion, Cantidad);

        } while (true);
    }
}