using Soenneker.Tests.HostedUnit;
using AwesomeAssertions;
using System;

namespace Soenneker.Utils.TimeSpans.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class TimeSpansUtilTests : HostedUnitTest
{

    public TimeSpansUtilTests(Host host) : base(host)
    {

    }

    [Test]
    public void GetEarliestTimeInDay_returns_midnight()
    {
        TimeSpansUtil.GetEarliestTimeInDay().Should().Be(TimeSpan.Zero);
    }

    [Test]
    public void GetLatestTimeInDay_returns_tick_before_next_midnight()
    {
        TimeSpansUtil.GetLatestTimeInDay().Should().Be(TimeSpan.FromDays(1) - TimeSpan.FromTicks(1));
    }
}
