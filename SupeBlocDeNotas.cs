using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SuperBlocDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opcion = 0;
            do
            {
                Console.WriteLine("Escoja una opción y presione \"ENTER\": \n\n" +
                "1.- Crear archivo\n" +
                "2.- Mostrar contenido\n" +
                "3.- Agregar texto\n" +
                "4.- Salir\n\n");

                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("CREAR ARCHIVO:\n");
                        TextWriter archivo = new StreamWriter("archivo.txt");
                        Console.Clear();
                        Console.WriteLine("Archivo creado. Presione \"ENTER\" para volver al MENU.");
                        Console.ReadLine();
                        Console.Clear();
                        archivo.Close();
                        archivo.Dispose();
                        GC.Collect();
                        break;
                    case 2:
                     try
                        { 
                        Console.Clear();
                        Console.WriteLine("MOSTRAR CONTENIDO:\n");
                        if (File.Exists("archivo.txt"))
                        {
                            TextReader lectura = new StreamReader("archivo.txt");
                            Console.WriteLine(lectura.ReadToEnd());
                            Console.WriteLine("Presiona \"ENTER\" para volver a MENU.");
                            Console.ReadLine();
                            Console.Clear();
                            lectura.Close();
                            lectura.Dispose();
                            GC.Collect();
                        }
                        else
                        {
                                Console.Clear();
                                Console.WriteLine("Este archivo no existe en la ruta especificada\n.Presione \"ENTER\" para "+
                                    "regresar a MENU");
                                Console.ReadLine();
                                Console.Clear();
                            }
                     }
                  catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("AGREGAR CONTENIDO");
                        StreamWriter escritura = File.AppendText("archivo.txt");
                        Console.WriteLine("Escriba su texto:\n\n");
                        String texto = null;
                        texto = Console.ReadLine();
                        escritura.WriteLine(texto);
                        Console.WriteLine("Presiona \"ENTER\" para volver a MENU.");
                        Console.ReadLine();
                        Console.Clear();
                        escritura.Close();
                        escritura.Dispose();
                        GC.Collect();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo de la aplicación");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida.Presione \"ENTER\" para volver a MENU.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (opcion != 4);
        }
    }
}
