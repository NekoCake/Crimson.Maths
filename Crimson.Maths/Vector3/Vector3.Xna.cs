#if XNA4 || XNA31
namespace Crimson.Maths
{
    using System.Runtime.InteropServices;
    using XnaVector3 = Microsoft.Xna.Framework.Vector3;

    public partial struct Vector3
    {
        [FieldOffset(0)]
        public XnaVector3 InternalVector3;

        public static implicit operator XnaVector3(Vector3 @this)
        {
            return @this.InternalVector3;
        }

        public static implicit operator Vector3(XnaVector3 @this)
        {
            Vector3 result = new Vector3();
            result.InternalVector3 = @this;
            return result;
        }
    }
}
#endif
