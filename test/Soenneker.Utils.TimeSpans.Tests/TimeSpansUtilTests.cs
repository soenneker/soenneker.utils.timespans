using Soenneker.Tests.HostedUnit;

namespace Soenneker.Utils.TimeSpans.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class TimeSpansUtilTests : HostedUnitTest
{

    public TimeSpansUtilTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
