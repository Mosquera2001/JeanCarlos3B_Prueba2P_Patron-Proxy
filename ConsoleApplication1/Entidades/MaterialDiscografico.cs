using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    //Esta sera la clase principal material discográfico ya que esta será creada a través del patrón como se puede
    //observar esta clase tiene como atributos otras clases y es perfecto para el patrón builder

    public class MaterialDiscografico
    {
        private String nombre;
        private double duracionTotal;
        private GeneroMusical genero;
        private Artista autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<CancionAlbum> canciones;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

       

        public double DuracionTotalminutos
        {
            get { return duracionTotal; }
            set { duracionTotal = value; }
        }

        public GeneroMusical Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public Artista Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public TipoMaterialDiscografico TipoMaterialDiscografico
        {
            get { return tipoMaterialDiscografico; }
            set { tipoMaterialDiscografico = value; }
        }

        public List<CancionAlbum> Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }

        public String DatosCanciones()
        {
            int numeroDeCancion = 1;
            String datos = "\nCANCIONES";

            foreach(CancionAlbum cancion in canciones)
            {
                datos+=
                    "\nNº "+ numeroDeCancion.ToString()+
                    "\nNombre de la canción: "+ cancion.NombreCancion+
                    "\nDuracion: "+ cancion.Duracionminutos.ToString() + " Minutos";

                numeroDeCancion++;
            }

            return datos;
        }

        public String ReportarDatos()
        {
            return 
                   "REPORTE DE MATERIAL" +
                   "\nNombre de la disquera: " + nombre +
                   "\nDuracion total del albúm: " + duracionTotal + " minutos" +
                   "\n--------------------" +
                   "\nAUTOR" +
                   "\nNombre: " + autor.NombreArtista +
                   "\nDescripcion: " + autor.DescripcionArtista +
                   "\n--------------------" +
                   "\nGENERO" +
                   "\nGENERO MUSICAL: " + genero.DescripcionGenero +
                   "\n--------------------" +
                   "\nMATERIAL DISCOGRAFICO" +
                   "\nNombre del Albúm: " + tipoMaterialDiscografico.NombreTipoMaterialDiscografico +
                   "\n--------------------" +
                   DatosCanciones();
        }

    }
}
