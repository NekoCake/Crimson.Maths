namespace Crimson.Maths
{
    public partial struct Vector3
    {

        public static float Dot(Vector3 a, Vector3 b)
        {
            return (((a.X*b.X) + (a.Y*b.Y)) + (a.Z*b.Z));
        }

        public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
        {
            result = ((vector1.X * vector2.X) + (vector1.Y * vector2.Y)) + (vector1.Z * vector2.Z);
        }
    }
}
