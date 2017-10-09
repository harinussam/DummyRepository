using NUnit.Framework;

namespace AttributesDemo.Tests.DataDrivenTests
{  
    [TestFixture]
    public class ClassWithIntermittentBugTests
    {        
        [Test]
        [Ignore]
        [Repeat(10000)]
        public void ShouldDoWork()
        {
            var sut = new ClassWithIntermittentBug();

            sut.DoWork();            
        }
    }
}
