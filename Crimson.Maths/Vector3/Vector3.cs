using System.Globalization;
using System.Runtime.InteropServices;

namespace Crimson.Maths
{
    /// <summary>
    /// Defines a vector with three components. 
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct Vector3
    {
        [FieldOffset(0)]
        public float X;
        [FieldOffset(4)]
        public float Y;
        [FieldOffset(8)]
        public float Z;

        public override string ToString()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            return string.Format(currentCulture, "{{X:{0}, Y:{1}, Z:{2}}}", this.X.ToString(currentCulture), this.Y.ToString(currentCulture), this.Z.ToString(currentCulture));
        }
    }
}
