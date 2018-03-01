namespace Composition.Template
{
    public class Brewer2
    {
        public virtual string Brew(params string[] ingredients)
        {
            return string.Join(",", ingredients);
        }
    }
}