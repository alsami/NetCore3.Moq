using System;
using Moq;
using NetCore3.Lib;
using Xunit;

namespace NetCore3.Tests
{
    public class SampleTests
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<ISomeDependency>();
            mock.Setup(sd => sd.IsValid(It.IsAny<string>()))
                .Returns(true);
        }
    }
}