using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class CancionAlbum
    {
        private String nombreCancion;
        private int duracionminutos;

        public CancionAlbum(String nombreCancion, int duracionminutos)
        {
            this.nombreCancion = nombreCancion;
            this.duracionminutos = duracionminutos;
        }

        public String NombreCancion
        {
            get { return nombreCancion; }
            set { nombreCancion = value; }
        }

        public int Duracionminutos
        {
            get { return duracionminutos; }
            set { duracionminutos = value; }
        }

    }
}
