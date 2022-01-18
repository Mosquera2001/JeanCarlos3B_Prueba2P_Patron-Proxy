using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entidades;

namespace ConsoleApplication1.Builder
{
    public interface IMaterialDiscograficoBuilder
    {
        //interfaz que poseerá métodos que actuarán como setters en los atributos de las clases material discográfico 

        MaterialDiscograficoBuilder ConNombre(String nombre);
        MaterialDiscograficoBuilder ComoGenero(GeneroMusical genero);
        MaterialDiscograficoBuilder ComoAutor(Artista autor);
        MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico);
        MaterialDiscograficoBuilder ComoCanciones(List<CancionAlbum> canciones);
    }
}
