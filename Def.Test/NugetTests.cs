using System;
using System.Reflection;
using Xunit;

namespace Def.Test
{
    public class NuGetTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal($@"{NuGet.PackagesPath}def.test\1.0.0\", NuGet.PackageFolder(Assembly.GetExecutingAssembly()));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal($@"{NuGet.PackagesPath}def\1.2.3.4\", NuGet.PackageFolder("def", new Version(1, 2, 3, 4)));
            Assert.Equal($@"{NuGet.PackagesPath}def\1.2.3\", NuGet.PackageFolder("def", new Version(1, 2, 3)));
            Assert.Equal($@"{NuGet.PackagesPath}def\1.2.0\", NuGet.PackageFolder("def", new Version(1, 2)));
        }

        [Fact]
        public void PreviewTest()
        {
            Assert.Equal($@"{NuGet.PackagesPath}def\1.2.3.4-alpha\", NuGet.PackageFolder("def", new Version(1, 2, 3, 4), "alpha"));
            Assert.Equal($@"{NuGet.PackagesPath}def\1.2.3-alpha\", NuGet.PackageFolder("def", new Version(1, 2, 3), "alpha"));
            Assert.Equal($@"{NuGet.PackagesPath}def\1.2.0-alpha\", NuGet.PackageFolder("def", new Version(1, 2), "alpha"));
        }

    }
}
