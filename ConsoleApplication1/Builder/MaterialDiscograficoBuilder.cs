using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entidades;

namespace ConsoleApplication1.Builder
{
    // SE HACE LA IMPLEMENTACION DE LA INTERFACE MATERIAL DISCOGRAFICO
    
    public class MaterialDiscograficoBuilder 
    {
        private String nombre;
        private GeneroMusical genero;
        private Artista autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<CancionAlbum> canciones;

        public MaterialDiscograficoBuilder ConNombre(String nombre)
        {
            this.nombre = nombre;
            return this;
        }

        

        public MaterialDiscograficoBuilder ComoGenero(GeneroMusical genero)
        {
            this.genero = genero;
            return this;
        }

        public MaterialDiscograficoBuilder ComoAutor(Artista autor)
        {
            this.autor = autor;
            return this;
        }

        public MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico)
        {
            this.tipoMaterialDiscografico = tipoMaterialDiscografico;
            return this;
        }

        public MaterialDiscograficoBuilder ComoCanciones(List<CancionAlbum> canciones)
        {
            this.canciones = canciones;
            return this;
        }

        //Se implementa métodos que sean los atributos del Builder y a su vez retornan en el mismo  pero con los atributos modificados

        private int CalcularDuracionTotal()
        {
            int duracionTotal = 0;

            foreach(CancionAlbum cancion in canciones)
            {
                duracionTotal += cancion.Duracionminutos;
            }

            return duracionTotal;
        }

        public MaterialDiscografico BuildMaterialDiscografico()
        {
            
            return new MaterialDiscografico()
            {

                Nombre = this.nombre,
                DuracionTotalminutos = CalcularDuracionTotal(),
                Genero = this.genero,
                Autor = this.autor,
                TipoMaterialDiscografico = this.tipoMaterialDiscografico,
                Canciones = this.canciones

                // SE RETORNA UNA INSTANCIA DEL MATERIAL DISCOGRAFICO RECOLECTADO A LO LARGO DE LOS METODOS
                
            };
        }
    }
}
