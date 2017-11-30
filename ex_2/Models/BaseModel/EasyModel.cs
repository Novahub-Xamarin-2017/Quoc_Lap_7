using System.Linq;

namespace Exercise2.Models.BaseModel
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