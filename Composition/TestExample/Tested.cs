namespace Composition.TestExample
{
    public class Tested
    {
        readonly Dependency _dependency;

        public Tested(Dependency dependency)
        {
            _dependency = dependency;
        }

        public int Foo(double input)
        {
            //Use dependency
            var dependentOutput = _dependency.Bar(input);

            //Add my own special sauce
            return dependentOutput + 5;
        }
    }
}