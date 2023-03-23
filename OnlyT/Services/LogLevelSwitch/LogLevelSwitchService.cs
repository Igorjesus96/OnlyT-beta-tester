﻿using Serilog.Core;
using Serilog.Events;

namespace OnlyT.Services.LogLevelSwitch;

// ReSharper disable once ClassNeverInstantiated.Global
public class LogLevelSwitchService : ILogLevelSwitchService
{
    public static readonly LoggingLevelSwitch LevelSwitch = new()
    {
        MinimumLevel = LogEventLevel.Information
    };

    public void SetMinimumLevel(LogEventLevel level)
    {
        LevelSwitch.MinimumLevel = level;
    }
}