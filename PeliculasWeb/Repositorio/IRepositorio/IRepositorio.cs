using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasWeb.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<IEnumerable> GetTodoAsync(string url);
        // Metodo para filtrar en peliculas en una categoria
        Task<IEnumerable> GetPeliculasEnCategoriasAsync(string url, int categoriaId);
        // Metodo para buscar peliculas por nombre
        Task<IEnumerable> Buscar(string url, string nombre);
        Task<T> GetAsync(string url, int Id);

        Task<bool> CrearAsync(string url, T itemCrear);

        Task<bool> ActualizarAsync(string url, T itemActualizar);

        Task<bool> BorrarAsync(string url, int id);
    }
}
