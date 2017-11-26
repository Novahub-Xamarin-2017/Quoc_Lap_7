using System.Linq;

namespace ex3.models
{
    public class EasyModel
    {
        public override string ToString()
        {
            return string.Join(", ", GetType().GetProperties()
                .Where(x => x.CanRead)
                .Select(x => $"{x.Name}: {x.GetValue(this)}"));
        }
    }
}