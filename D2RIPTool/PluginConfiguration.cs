using System;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace DRIPTool
{
    public class PluginConfiguration
    {
        public float ScalingFactor { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public PluginConfiguration()
        {
            ScalingFactor = 1f;
            PositionX = 5f;
            PositionY = 30f;
        }
    }
}
