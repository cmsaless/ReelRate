using Microsoft.EntityFrameworkCore;
using ReelRate.Project.Contracts;
using ReelRate.Project.Data;
using ReelRate.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReelRate.Project
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal ApplicationDbContext Context;
        internal DbSet<T> DBSet;

        public SQLRepository(ApplicationDbContext context)
        {
            Context = context;
            DBSet = context.Set<T>();
        }

        public IQueryable<T> Collection()
        {
            return DBSet;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Delete(string ID)
        {
            var t = Find(ID);
            if (Context.Entry(t).State == EntityState.Detached)
            {
                DBSet.Attach(t);
            }

            DBSet.Remove(t);
        }

        public T Find(string ID)
        {
            return DBSet.Find(ID);
        }

        public void Insert(T t)
        {
            DBSet.Add(t);
        }

        public void Update(T t)
        {
            DBSet.Attach(t);
            Context.Entry(t).State = EntityState.Modified;
        }
    }
}
