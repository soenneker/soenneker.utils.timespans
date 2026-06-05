using System;
using System.Diagnostics.Contracts;

namespace Soenneker.Utils.TimeSpans;

/// <summary>
/// Represents the time spans util.
/// </summary>
public static class TimeSpansUtil
{
    /// <returns>Very first instant of day (smallest possible TimeSpan)</returns>
    [Pure]
    public static TimeSpan GetEarliestTimeInDay()
    {
        return new TimeSpan(1);
    }

    /// <returns>Very last instant of day (Max TicksPerDay - 1)</returns>
    [Pure]
    public static TimeSpan GetLatestTimeInDay()
    {
        return new TimeSpan(TimeSpan.TicksPerDay - 1);
    }
}
