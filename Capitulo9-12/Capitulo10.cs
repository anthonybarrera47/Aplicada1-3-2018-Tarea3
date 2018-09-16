using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9_12
{
    public class Capitulo10
    {
        public Capitulo10()
        {

        }
        class Ejercicio1//Crear el diseño de una clase para llevar el inventario de una tienda.
        {
            public int Clave { get; set; }
            public String Articulo { get; set; }
            public DateTime FechaDeCompra { get; set; }
            public float Cantidad { get; set; }
            public float CostoUnitario { get; set; }
            public float CostoTotal { get; set; }
        }
        class Ejercicio2//Crear una clase para llevar la información de los estudiantes de una escuela.
        {
            public String Nombres { get; set; }
            public String Apellidos { get; set; }
            public int Edad { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public String CursoAcademico { get; set; }
            public String NombrePadre { get; set; }
            public String NombreMadre { get; set; }
        }
        class Ejercicio3//Crear una clase para polígonos con sobrecarga del constructor.
        {
            public float LongitudLado { get; set; }
            public int CantidadLado { get; set; }

            public Ejercicio3()
            {
                LongitudLado = 0;
                CantidadLado = 0;
            }
            public Ejercicio3(float longitud,int cantidad)
            {
                LongitudLado = longitud;
                CantidadLado = cantidad;
            }

        }
        public class Ejercicio4 // Crear propiedades para la clase polígono que solamente permitan colocar valores válidos.
        {
            public float LongitudLado
            {
                get
                {
                    return LongitudLado;
                }
                set
                {
                    if (LongitudLado > 0)
                    {
                        LongitudLado = value;
                        return;
                    }
                    LongitudLado = 0;

                }
            }
            public int CantidadLado
            {
                get
                {
                    return CantidadLado;
                }
                set
                {
                    if (CantidadLado > 0)
                    {
                        CantidadLado = value;
                        return;
                    }
                    CantidadLado = 0;

                }
            }
            public Ejercicio4()
            {
                CantidadLado = 0;
                LongitudLado = 0;
            }
            public Ejercicio4(int lados,float longitud)
            {
                CantidadLado = lados;
                LongitudLado = longitud;
            }  
        }
        class Ejercicio5 : Ejercicio4 //Programar el método ToString() para la clase polígono.
        {
            public override string ToString()
            {
                return "La cantidad de Lado es: " + CantidadLado + "\nLa longitud de Cada Lado es: " + LongitudLado;
            }
        }
            
    }
    
}
