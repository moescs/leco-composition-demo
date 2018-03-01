namespace Composition.Template
{
    public class Brewer3
    {
        public virtual string Brew(params string[] ingredients)
        {
            return string.Join(",", ingredients);
        }
    }
}