using UnityEngine;

namespace WarheadCustomColor.Features
{
    public class SerializableColor
    {

        public SerializableColor()
        {
            
        }
        public SerializableColor(byte r, byte g, byte b, byte w)
        {
            R = r;
            G = g;
            B = b;
            W = w;
        }

        public SerializableColor(Vector4 color): this((byte)color.x, (byte)color.y, (byte)color.z, (byte)color.w){}

        /// <summary>
        /// Red color
        /// </summary>
        public byte R { get; set; } = 0;
        /// <summary>
        /// Green color
        /// </summary>
        public byte G { get; set; } = 0;

        /// <summary>
        /// Blue color
        /// </summary>
        public byte B { get; set; } = 0;
        
        /// <summary>
        /// Brightness color
        /// </summary>
        public byte W { get; set; } = 0;
        
        public static implicit operator Color(SerializableColor a) => new Color(a.R, a.G, a.B);
        public static implicit operator Vector4(SerializableColor a) => new Vector4(a.R, a.G, a.B, a.W);
        public static explicit operator SerializableColor(Vector4 a) => new SerializableColor(a);
    }
}