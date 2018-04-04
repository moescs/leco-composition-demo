namespace Composition.Template
{
    /// <summary>
    /// Helper class - the details of which are irrelevant
    /// </summary>
    public class Brewer3
    {
        public virtual string Brew(params string[] ingredients)
        {
            return string.Join(",", ingredients);
        }
    }
}