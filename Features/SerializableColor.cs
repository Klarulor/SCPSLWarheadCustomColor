using UnityEngine;

namespace WarheadCustomColor.Features
{
    public class SerializableColor
    {

        public SerializableColor()
        {
            
        }
        public SerializableColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public SerializableColor(Vector3 color): this((byte)color.x, (byte)color.y, (byte)color.z){}

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
        
        public static implicit operator Color(SerializableColor a) => new Color(a.R, a.G, a.B);
        public static implicit operator Vector3(SerializableColor a) => new Vector3(a.R, a.G, a.B);
        public static explicit operator SerializableColor(Vector3 a) => new SerializableColor(a);
    }
}