[![](https://img.shields.io/nuget/v/soenneker.utils.timespans.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.timespans/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.timespans/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.timespans/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.timespans.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.timespans/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.timespans/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.timespans/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.TimeSpans
A utility library for TimeSpan related operations.

## Installation

```bash
dotnet add package Soenneker.Utils.TimeSpans
```

## Quick start

```csharp
using Soenneker.Utils.TimeSpans;
```

Call the static `TimeSpansUtil` methods directly; no dependency-injection registration is required.

## Common operations

- `GetEarliestTimeInDay()` - Returns very first instant of day (smallest possible TimeSpan).
- `GetLatestTimeInDay()` - Returns very last instant of day (Max TicksPerDay - 1).
