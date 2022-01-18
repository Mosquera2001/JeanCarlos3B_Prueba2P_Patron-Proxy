using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class GeneroMusical
    {
        private String descripcionGenero;

        public GeneroMusical(String descripcionGenero)
        {
            this.descripcionGenero = descripcionGenero;
        }

        public String DescripcionGenero
        {
            get { return descripcionGenero; }
            set { descripcionGenero = value; }
        }
    }
}
