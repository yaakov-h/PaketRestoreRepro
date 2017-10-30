using NUnit.Framework;

namespace ClassLibrary2
{
    class Class1
    {
        [Test]
        public void MadeSomeJson() => Assert.That(ClassLibrary1.Class1.MakeSomeJson(), Is.Not.Null.Or.Empty);
    }
}
