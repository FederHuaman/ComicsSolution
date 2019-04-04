using System;
using System.Collections.Generic;
using System.Linq;
using Comics.Domain.Entities;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Comics.Domain.Interfaces
{
    // Patro repositorio
    public interface IComicRepository
    {
        // IQueryable: Recomendable solo cuando ser reutilizadao desde otro metod
        // Composicion: Unir con otro, agregar clausulas. 
        IQueryable<Comic> TraerTodos(); // Select * from 

        Task<IEnumerable<Comic>> BuscarPorNombreAsync(string nombre); // where nombre = xyz

        // Delegate: Puntero que apunta a un metodo
        /**
         * Delagados: 
         *  Fun<> Apunta a una funcion
         *  Action Apunta a un metodo que no devuelve nada void
         */
        Task<Comic> TraerPorIdAsync(int id);

        Task<IEnumerable<Comic>> BuscarAsync(Expression<Func<Comic, bool>> filtro);

        void Agregar(Comic comic);

        void Editar(Comic comic);

        Task<bool> EliminarAsync(int id);

        Task GuardarAsync();
    }
}
