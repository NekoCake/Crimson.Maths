#if SlimDX
namespace Crimson.Maths
{
    using System.Runtime.InteropServices;
    using SlimVector3 = SlimDX.Vector3;

    public partial struct Vector3
    {
        [FieldOffset(0)]
        public SlimVector3 SlimDXVector3;

        public static implicit operator SlimVector3(Vector3 @this)
        {
            return @this.SlimDXVector3;
        }

        public static implicit operator Vector3(SlimVector3 @this)
        {
            Vector3 result = new Vector3();
            result.SlimDXVector3 = @this;
            return result;
        }
    }
}
#endif