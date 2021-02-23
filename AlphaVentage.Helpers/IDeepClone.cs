using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVentage.Helpers
{
    public static class MonadPattern
    {
        public static T DeepClone<T>(this T item) where T : IDeepCloneable
        {
            return new DeepCloneHelper<T>().DeepClone(item);
        }
    }
    public interface IDeepCloneable
    {

    }
    public class DeepCloneHelper<T> : IDeepClone<T>
    {
        public T DeepClone(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }

    public interface IDeepClone<T>
    {
        T DeepClone(T obj);
    }
}
