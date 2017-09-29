using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.Extension
{
    public static class Extension
    {
        public static T Changer<T>(this object source)
        {
            T target = Activator.CreateInstance<T>();
            Type newsource = source.GetType();

            PropertyInfo[] sourceProps = newsource.GetProperties();
            PropertyInfo[] targetProps = typeof(T).GetProperties();

            foreach (PropertyInfo pi in sourceProps)
            {
                object value = pi.GetValue(source);
                PropertyInfo hp = targetProps.FirstOrDefault(x => x.Name == pi.Name);

                if (hp != null)
                {
                    hp.SetValue(target, value);
                }
            }

            return target;
        }
    }
}
