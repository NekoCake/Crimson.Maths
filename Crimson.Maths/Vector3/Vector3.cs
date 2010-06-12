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
            return string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
        }
    }

#if XNA4 || XNA31
    public partial struct Vector3
    {
        [FieldOffset(0)]
        public Microsoft.Xna.Framework.Vector3 InternalXnaVector;

        public static implicit operator Microsoft.Xna.Framework.Vector3(Vector3 @this)
        {
            return @this.InternalXnaVector;
        }

        public static implicit operator Vector3(Microsoft.Xna.Framework.Vector3 @this)
        {
            Vector3 @return = new Vector3();
            @return.InternalXnaVector = @this;
            return @return;
        }
    }
#endif
}
