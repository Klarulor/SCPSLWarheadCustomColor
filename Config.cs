using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using WarheadCustomColor.Features;

namespace WarheadCustomColor
{
    public sealed class Config : IConfig
    {
        [Description("Enable")]
        public bool IsEnabled { get; set; } = true;

        [Description("Warhead color 0-255")]
        public SerializableColor WarheadColor { get; set; } = new SerializableColor(120, 60, 80, 1);

        [Description("How long the lights are off after detonation in seconds")]
        public float WarheadBlackoutDelay { get; set; } = 2f;
    }
}
