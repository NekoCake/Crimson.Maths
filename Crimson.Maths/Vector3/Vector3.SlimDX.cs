#if SlimDX
namespace Crimson.Maths
{
    using System.Runtime.InteropServices;
    using SlimVector3 = SlimDX.Vector3;

    public partial struct Vector3
    {
        [FieldOffset(0)]
        public SlimVector3 InternalVector3;

        public static implicit operator SlimVector3(Vector3 @this)
        {
            return @this.InternalVector3;
        }

        public static implicit operator Vector3(SlimVector3 @this)
        {
            Vector3 @return = new Vector3();
            @return.InternalVector3 = @this;
            return @return;
        }
    }
}
#endif