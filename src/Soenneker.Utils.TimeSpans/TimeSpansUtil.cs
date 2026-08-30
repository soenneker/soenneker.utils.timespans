using System;
using System.Diagnostics.Contracts;

namespace Soenneker.Utils.TimeSpans;

/// <summary>
/// Represents the time spans util.
/// </summary>
public static class TimeSpansUtil
{
    /// <summary>
    /// Returns midnight, the earliest representable time within a day.
    /// </summary>
    /// <returns><see cref="TimeSpan.Zero"/>.</returns>
    [Pure]
    public static TimeSpan GetEarliestTimeInDay()
    {
        return TimeSpan.Zero;
    }

    /// <summary>
    /// Returns the final tick before midnight of the following day.
    /// </summary>
    /// <returns>One day minus one tick.</returns>
    [Pure]
    public static TimeSpan GetLatestTimeInDay()
    {
        return new TimeSpan(TimeSpan.TicksPerDay - 1);
    }
}
