namespace Crimson.Maths
{
    public partial struct Vector3
    {
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            Vector3 @return;
#if InternalMaths
            @return.X = a.X + b.X;
            @return.Y = a.Y + b.Y;
            @return.Z = a.Z + b.Z;
#elif XNA4 || XNA31
            @return = new Vector3();
            Microsoft.Xna.Framework.Vector3.Add(ref a.InternalXnaVector, ref b.InternalXnaVector, out  @return.InternalXnaVector);
#endif
            return @return;
        }
    }
}
