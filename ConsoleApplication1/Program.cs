using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entidades;
using ConsoleApplication1.Builder;

namespace ConsoleApplication1
{
    class Program
    {
        //Tenemos que conocer la distribución del proyecto este está compuesto por tres partes principales
        //la primera parte son las clases que implementan el patrón Builder
        //la segunda parte son las entidades que se usarán para la creación del material discográfico como el material discográfico en sí 
        //la última parte está la clase main del programa en la cual se ejecutara el codigo
        static void Main(string[] args)
        {
            int numeroDeCancion = 1;

            // MATERIAL DISCOGRAFICO
            String nombre;

            // AUTOR
            Artista autor;
            String nombreArtista;
            String descripcionArtista;

            // GENERO
            GeneroMusical genero;
            String descripcionGenero;

            // TIPO MATERIAL DISCOGRAFICO
            TipoMaterialDiscografico tipoMaterialDiscografico;
            String nombreMaterialDiscografico;

            // CANCIONES
            List<CancionAlbum> canciones = new List<CancionAlbum>();
            CancionAlbum cancion;
            String nombreCancion;
            int duracionminutos;

            char respuesta;


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("---------------| DISCOGRAFIA MUSICAL |----------------------");
            Console.WriteLine("-----------------------------BY: JEAN CARLOS MOSQUERA-------");
            Console.WriteLine("------------------------------------------------------------");

            // MATERIAL DISCOGRAFICO (NOMBRE DE LA DISQUERA)
            Console.Write("Ingrese el nombre de la Disquera: ");
            nombre = Console.ReadLine();
            
            // DATOS DEL AUTOR
            Console.Write("Ingrese el nombre del artista: ");
            nombreArtista = Console.ReadLine();
            Console.Write("Ingrese descripcion del artista: ");
            descripcionArtista = Console.ReadLine();
            autor = new Artista(nombreArtista, descripcionArtista);

            // GENERO MUSICAL
            Console.Write("Ingrese el tipo del genero musical: ");
            descripcionGenero = Console.ReadLine();
            genero = new GeneroMusical(descripcionGenero);

            // MATERIAL DISCOGRAFICO ( NOMBRE DEL ALBUM)...
            Console.Write("Ingrese el nombre del Albúm: ");
            nombreMaterialDiscografico = Console.ReadLine();
            tipoMaterialDiscografico = new TipoMaterialDiscografico(nombreMaterialDiscografico);

            do
            {
                // INGRESO DE LAS CANCIONES DEL ALBUM...
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\nCancion " + numeroDeCancion.ToString());
                Console.Write("Ingrese el nombre de la canción: ");
                nombreCancion = Console.ReadLine();
                Console.Write("Ingrese la duracion de la cancion en minutos: ");
                duracionminutos = Convert.ToInt32(Console.ReadLine());

                cancion = new CancionAlbum(nombreCancion, duracionminutos);
                canciones.Add(cancion);

                numeroDeCancion++;
                
                Console.Write("Desea seguir agregando canciones? (S/N): ");
                respuesta = Console.ReadKey().KeyChar;
                Console.ReadKey();

            } while (respuesta == 'S' || respuesta == 's');
            // UTILIZAMOS EL DO WHILE PARA INIDICAR AL USUARIO SI DESEA CONTINUAR INGRESANDO MUSICAS O NO
            Console.Clear();

            // BUILDER MATERIAL DISCOGRAFICO
            MaterialDiscograficoBuilder builderMaterialDiscografico = new MaterialDiscograficoBuilder();
            MaterialDiscografico materialDiscografico = builderMaterialDiscografico
                .ConNombre(nombre)
                .ComoAutor(autor)
                .ComoCanciones(canciones)
                .ComoGenero(genero)
                .ComoTipoMaterialDiscografico(tipoMaterialDiscografico)
                .BuildMaterialDiscografico();

            // REPORTAR
            Console.Write(materialDiscografico.ReportarDatos());

            Console.ReadKey();
        }
    }
}
