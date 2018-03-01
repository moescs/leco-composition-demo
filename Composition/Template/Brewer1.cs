namespace Composition.Template
{
    using System.Linq;

    public class Brewer1
    {
        public virtual string Brew(params string[] ingredients)
        {
            return string.Join(",", ingredients);
        }
    }
}