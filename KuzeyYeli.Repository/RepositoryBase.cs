using KuzeyYeli.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Repository
{
    public class RepositoryBase<TT> : IRepository<TT> where TT: class
    {
        private static KuzeyYeliContext context;

        public static KuzeyYeliContext Context
        {
            get
            {
                context = context ?? new KuzeyYeliContext();
                return context;
            }

            set
            {
                context = value;
            }
        }
        public bool Delete(TT entity)
        {
            TT existing = context.Set<TT>().Find(GetKeys(entity, Context));

            if (existing != null)
            {
                context.Set<TT>().Remove(existing);

            }

            else
            {
                return false;
            }

            try
            {
                return Context.SaveChanges() > 0;
            }

            catch (Exception)
            {
                return false;
            }

        }

        private object[] GetKeys<T>(T entity, DbContext context) where T : class
        {
            ObjectContext objectContext = ((IObjectContextAdapter)context).ObjectContext;
            ObjectSet<T> set = objectContext.CreateObjectSet<T>();
            var keyNames = set.EntitySet.ElementType
                                                        .KeyMembers
                                                        .Select(k => k.Name).ToArray();
            Type type = typeof(T);

            object[] keys = new object[keyNames.Length];
            for (int i = 0; i < keyNames.Length; i++)
            {
                keys[i] = type.GetProperty(keyNames[i]).GetValue(entity, null);
            }
            return keys;
        }

        public bool Insert(TT entity)
        {
            Context.Set<TT>().Add(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }

            catch(Exception)
            {
                return false;
            }

        }

        public List<TT> List()
        {
            return Context.Set<TT>().ToList();
        }

        public bool Update(TT entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            try
            {
                return Context.SaveChanges() > 0;
            }

            catch
            {
                return false;
            }
        }
    }
}
