namespace Composition.Template
{
    /// <summary>
    /// Helper class - the details of which are irrelevant
    /// </summary>
    public class Brewer2
    {
        public virtual string Brew(params string[] ingredients)
        {
            return string.Join(",", ingredients);
        }
    }
}