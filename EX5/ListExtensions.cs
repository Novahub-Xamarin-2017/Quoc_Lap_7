using System.Collections.Generic;

namespace EX5
{
    public static class ListExtensions
    {

        public static IEnumerable<List<T>> SubList<T>(this IList<T> list, int max)
        {
            var subList = new List<T>();
            foreach (var value in list)
            {
                subList.Add(value);
                if (subList.Count==max)
                {
                    yield return subList;
                    subList = new List<T>();
                }
            }
            if (subList.Count!=0)
            {
                yield return subList;
            }
        }
    }
}