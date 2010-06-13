namespace Crimson.Maths
{
#if XNA4 || XNA31
    using XnaVector3 = Microsoft.Xna.Framework.Vector3;
#endif

    public partial struct Vector3
    {
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
                Z = a.Z + b.Z
            };
        }

        public static void Add(ref Vector3 a, ref Vector3 b, out Vector3 @return)
        {
            @return = new Vector3
                         {
                             X = a.X + b.X, 
                             Y = a.Y + b.Y, 
                             Z = a.Z + b.Z
                         };
        }
    }
}
