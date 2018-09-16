using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9_12
{
    public class Capitulo9
    {
        public Capitulo9()
        {

        }
        //Estructura Perteneciente al Ejercicio 9.1.
        public struct ProductoTienda
        {
            public int CodigoDeBarras;
            public string NombreProducto;
            public int PrecioProducto;

            public ProductoTienda(int nCodigoDeBarras, string nNombreProducto, int nPrecioProducto)
            {
                CodigoDeBarras = nCodigoDeBarras;
                NombreProducto = nNombreProducto;
                PrecioProducto = nPrecioProducto;
            }
        }
        //Crear una estructura para guardar los productos de una tienda.
        public static void Ejercicio1()
        {
            ProductoTienda productoTienda;
            productoTienda.CodigoDeBarras = 00092;
            productoTienda.NombreProducto = "PAN";
            productoTienda.PrecioProducto = 50;
            Console.WriteLine("Codigo de Barras: " + productoTienda.CodigoDeBarras + "\nNombre del Producto: "
                              + productoTienda.NombreProducto + "\nPrecio del Producto: " + productoTienda.PrecioProducto);
            Console.WriteLine("\nPreciona una tecla para salir...");
            Console.ReadKey();
        }
        //La estructura dueño y Mascota Pertenecen al Mismo Ejercicio.
        public struct Mascota
        {
            public string NombreMascota;
            public int EdadMascota;
            public string RazaMascota;

            public Mascota(string sNombreMascota, int sEdadMascota, string sRazaMascota)
            {
                NombreMascota = sNombreMascota;
                EdadMascota = sEdadMascota;
                RazaMascota = sRazaMascota;
            }
        }

        public struct Dueño
        {
            public string NombreDueño;
            public int EdadDueño;
            public Mascota Perro;

            public Dueño(string sNombreDueño, int sEdadDueño, string NombreMascota, int EdadMascota, string RazaMascota)
            {
                NombreDueño = sNombreDueño;
                EdadDueño = sEdadDueño;
                Perro = new Mascota(NombreMascota, EdadMascota, RazaMascota);
            }
        }
        public static void Ejercicio3()//Crear estructuras enlazadas para guardar la información de una mascota y su dueño.
        {
            Dueño dueño;
            dueño.NombreDueño = "Anthony";
            dueño.EdadDueño = 17;
            dueño.Perro.NombreMascota = "Firulais";
            dueño.Perro.RazaMascota = "Doberman";
            dueño.Perro.EdadMascota = 2;
            Console.WriteLine("Nombre del Dueño: " + dueño.NombreDueño + "\nEdad del Dueño: "
                            + dueño.EdadDueño + "\nNombre de la Mascota: " + dueño.Perro.NombreMascota
                            + "\nTipo de Mascota: " + dueño.Perro.RazaMascota + "\nEdad de La Mascota: "
                            + dueño.Perro.EdadMascota);
            Console.WriteLine("\nPreciona una tecla para salir...");
        }
        //Enum Utilizado en el ejercicio 4.
        public enum Neumaticos
        {
            Neumáticos_Anchos,
            NeumáticosXL,
            NeumáticosBajo,
            NeumáticosUsados,
            NeumáticosRecauchutados,
            NeumáticosVerano,
            NeumáticosInvierno,
            NeumáticosTodoTiempo
        };

        public static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("Tipos de Neumaticos: ");
            Console.WriteLine(Neumaticos.Neumáticos_Anchos.ToString());
            Console.WriteLine(Neumaticos.NeumáticosBajo.ToString());
            Console.WriteLine(Neumaticos.NeumáticosInvierno.ToString());
            Console.WriteLine(Neumaticos.NeumáticosRecauchutados.ToString());
            Console.WriteLine(Neumaticos.NeumáticosTodoTiempo.ToString());
            Console.WriteLine(Neumaticos.NeumáticosUsados.ToString());
            Console.WriteLine(Neumaticos.NeumáticosVerano.ToString());
            Console.WriteLine(Neumaticos.NeumáticosXL.ToString());
            Console.ReadKey();
        }
    }
           
}
