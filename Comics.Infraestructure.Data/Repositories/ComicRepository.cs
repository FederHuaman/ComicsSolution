﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Comics.Domain.Entities;
using Comics.Domain.Interfaces; 
using Comics.Infraestructure.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Comics.Infraestructure.Data.Repositories
{
    class ComicRepository : IComicRepository
    {
        private readonly ComicsDbContext _db;
        public ComicRepository(ComicsDbContext db)
        {
            _db = db;
        }
        public void Editar(Comic comic)
        {
            _db.Comics.Attach(comic).State = EntityState.Modified;
        }

        public void Agregar(Comic comic)
        {
            // _db.Comics.Add(comic);
            // _db.Add(comic);
            _db.Add<Comic>(comic);
            // _db.AddAsync(comic);
        }

        public async Task<IEnumerable<Comic>> BuscarAsync(Expression<Func<Comic, bool>> filtro)
        {
            return await TraerTodos().Where(filtro).ToListAsync();
        }

        public Task<IEnumerable<Comic>> BuscarPorNombreAsync(string nombre)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var comic = await _db.Comics.FindAsync(id);
            if(comic != null)
            {
                _db.Remove(comic);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task GuardarAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Comic> TraerPorIdAsync(int id)
        {
            return await _db.Comics.FindAsync(id);
        }

        public IQueryable<Comic> TraerTodos()
        {
            return _db.Comics.AsQueryable();
        }
    }
}
