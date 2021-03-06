﻿using System;

namespace App
{
public class SystemClock : ISystemClock
{
    [CacheReturnValue]
    public DateTime GetCurrentTime(DateTimeKind dateTimeKind)
    {
        return dateTimeKind switch
        {
            DateTimeKind.Local => DateTime.UtcNow.ToLocalTime(),
            DateTimeKind.Unspecified => DateTime.Now,
            _ => DateTime.UtcNow,
        };
    }
}
}
