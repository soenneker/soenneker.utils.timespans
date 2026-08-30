[![](https://img.shields.io/nuget/v/soenneker.utils.timespans.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.timespans/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.timespans/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.timespans/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.timespans.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.timespans/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.timespans/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.timespans/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.TimeSpans
Exact `TimeSpan` boundaries for the beginning and end of a clock day.

## Installation

```bash
dotnet add package Soenneker.Utils.TimeSpans
```

## Usage

```csharp
using Soenneker.Utils.TimeSpans;

TimeSpan startOfDay = TimeSpansUtil.GetEarliestTimeInDay();
TimeSpan endOfDay = TimeSpansUtil.GetLatestTimeInDay();

// startOfDay == TimeSpan.Zero
// endOfDay == TimeSpan.FromDays(1) - TimeSpan.FromTicks(1)
```

Call the static `TimeSpansUtil` methods directly; no dependency-injection registration is required.

## Boundaries

- `GetEarliestTimeInDay()` returns midnight as `TimeSpan.Zero`.
- `GetLatestTimeInDay()` returns `23:59:59.9999999`, the final 100-nanosecond tick before the next midnight.

These values are time-of-day offsets, not dates, instants, or time-zone-aware values. For range queries, a half-open interval such as `[date, date.AddDays(1))` is often safer than relying on the final tick, especially when the backing store has different timestamp precision.
