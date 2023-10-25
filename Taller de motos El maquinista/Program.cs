using System;

namespace Taller_de_motos_El_maquinista
{
    class Program
    {
        /// <summary>
        /// Jorge Esteban Dawson Castillo       
        /// Programacion Etapa 3 ejercicio 3
        /// El taller de motos "El Maquinista" recibe motocicletas de alto cilindraje para realizar las respectivas revisiones y
        /// requiere una aplicación que le permita registrar los servicios generados a sus clientes.
        /// Para cada motocicleta se debe tener registro del ingreso al taller y las observaciones por parte del cliente También debe existir registro de salida del taller con las novedades
        /// y otra de arreglos hechos por el mecánico en caso de que se requiera inventariar cambios repuestos en la motocicleta al entregarla.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { //Al igual que en el ejercicio anterior voy a usar de metodos if para crear submenus en los cuales el mecanico pueda ingresar los datos
            string ObservaCliente;
            string Motivo;
            int opcion;
            string Cliente;
            string DatosMoto;
            string Fecha;
            string Salida;
            string arreglos;
            //Para este caso decidi definir todas las variables primero, ya que se me hicieron muchas más y recuerdo tuve que copiarlas varias veces en el anterior codigo
            Console.WriteLine("--------El Maquinista taller ---------");
            Console.WriteLine("menu principal");
            Console.WriteLine("1- ingreso y salida del taller");
            Console.WriteLine("2- Salir");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {//Uso la misma tecnica que en el ejercicio anterior
                if (opcion == 1)
                {
                    int opcion2;
                    Console.WriteLine("-------INGRESO TALLER--------");
                    Console.WriteLine("Cual es el motivo del ingreso:");
                    Motivo = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Que observaciones que el cliente tiene sobre la moto:");
                    ObservaCliente = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Cual es el nombre del propietario de la moto");
                    Cliente = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Pregunte al propietario los siguientes datos y registre en ese orden");
                    Console.WriteLine("----/Placas/---/Color/----/Cilindraje/");
                    DatosMoto = Console.ReadLine();
                    Console.WriteLine("Fecha de ingreso de la moto día-mes-año");
                    Fecha = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("----INGRESO REALIZADO CON EXITO----");
                    Console.WriteLine("DATOS DE INGRESO");
                    Console.WriteLine("Nombres del cliente " + Cliente);
                    Console.WriteLine(DatosMoto + " son los datos de la moto");
                    Console.WriteLine("Motivos de ingreso: " + Motivo);
                    Console.WriteLine("Observaciones del cliente: " + ObservaCliente);
                    Console.WriteLine("Con fecha de ingreso: " + Fecha);
                    Console.WriteLine("");
                    Console.WriteLine("Si desea dar salida a la moto precione 1, para salir presione 2");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opcion2 == 1)
                    {
                        Console.WriteLine("----SALIDA DE MOTOCICLETAS----");
                        Console.WriteLine("REGISTRO DE SALIDA");
                        Console.WriteLine("Ingrese si hubieron algunas novedades de lo contrario escriba /ninguna/");
                        Salida = Console.ReadLine();
                        Console.WriteLine("Ingrese los arreglos realizados y las partes utilizadas");
                        arreglos = Console.ReadLine();
                        Console.WriteLine("DATOS INICIALES DE INGRESO");
                        Console.WriteLine("Nombres del cliente " + Cliente);
                        Console.WriteLine(DatosMoto + " son los datos de la moto");
                        Console.WriteLine("Motivos de ingreso eran: " + Motivo);
                        Console.WriteLine("Observaciones del cliente eran: " + ObservaCliente);
                        Console.WriteLine("Todo con fecha de ingreso: " + Fecha);
                        Console.WriteLine("----DATOS DE SALIDA----");
                        Console.WriteLine("Novedades " + Salida);
                        Console.WriteLine("Arreglos y repuestos " + arreglos);
                        Console.WriteLine("<<<SALIDA EXITOSA>>>");
                    } if (opcion2 == 2)
                    {
                        Console.WriteLine("Cerrando Sistema");
                    }

                }
            }
            if (opcion == 2)
            {
                Console.WriteLine("Cerrando Sistema");
            }
            if (opcion <=0 || opcion >=3)
            {
                Console.WriteLine("Valor no valido, ingrese nuevamente");
            }
            //Como un bosquejo siento que funciona bien, me gustaria poder almacenar todas las variables en una base de datos pero no se como hacer algo así

        }
    }
}
