using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasWeb.Utilidades
{
    public static class CT
    {
        public static string UrlBaseApi = "https://localhost:44367/";

        public static string RutaCategoriasApi = UrlBaseApi + "api/Categorias/";

        public static string RutaPeliculasApi = UrlBaseApi + "api/Peliculas/";

        public static string RutaUsuariosApi = UrlBaseApi + "api/Usuarios/";

        // Faltan otras rutas para buscar y filtrar peliculas por categoria
        public static string RutaPeliculasEnCategoriaAPI = UrlBaseApi + "api/Peliculas/GetPeliculasEnCategoria/";
        public static string RutaPeliculasApiBusqueda = UrlBaseApi + "api/Peliculas/Buscar?nombre=";

    }
}
