﻿using Microsoft.EntityFrameworkCore;
using MVC.Contracts;
using MVC.Models;
using System;
using System.Linq;

namespace MVC.Data
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal ApplicationDbContext context;
        internal DbSet<T> dbSet;

        public SQLRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public IQueryable<T> Collection()
        {
            return dbSet;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Delete(string ID)
        {
            var t = Find(ID);

            if (context.Entry(t).State == EntityState.Detached)
            {
                dbSet.Attach(t);
            }

            dbSet.Remove(t);
        }

        public T Find(string ID)
        {
            return dbSet.Find(ID);
        }

        public void Insert(T t)
        {
            dbSet.Add(t);
        }

        public void Update(T t)
        {
            dbSet.Attach(t);
            context.Entry(t).State = EntityState.Modified;
        }
    }
}
