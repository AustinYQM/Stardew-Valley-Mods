﻿using Microsoft.Xna.Framework;

namespace Visualize
{
    public class Profile
    {
        public string name { get; set; } = "Visualize Profile";
        public string author { get; set; } = "none";
        public string version { get; set; } = "1.0.0";
        public string id { get; set; } = "auto";
        public int[] tint { get; set; } = new int[] { 255, 255, 255, 255 };
        public float saturation { get; set; } = 100;
        public float red { get; set; } = 100;
        public float green { get; set; } = 100;
        public float blue { get; set; } = 100;
        public float light { get; set; } = 100;
        public string palette { get; set; } = "none";
        public string shader { get; set; } = "none";
        public string shaderType { get; set; } = "none";
        public string handlerType { get; set; } = "none";
        public bool noAmbientLight { get; set; } = false;
        public bool noTransparancy { get; set; } = false;
        public bool noLightsources { get; set; } = false;
        public bool noShadow { get; set; } = false;
        public bool excludeFarmer { get; set; } = false;
    }
}
