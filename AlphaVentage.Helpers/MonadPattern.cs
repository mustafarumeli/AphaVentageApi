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
}
