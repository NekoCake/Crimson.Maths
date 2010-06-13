namespace Crimson.Maths
{
    public partial struct Vector3
    {
        public static Vector3 operator /(Vector3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X / b.X,
                Y = a.Y / b.Y,
                Z = a.Z / b.Z
            };
        }

        public static Vector3 operator /(Vector3 a, float divisor)
        {
            float num = 1f/divisor;
            return new Vector3
            {
                X = a.X * num,
                Y = a.Y * num,
                Z = a.Z * num
            };
        }

        public static Vector3 Divide(Vector3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X / b.X,
                Y = a.Y / b.Y,
                Z = a.Z / b.Z
            };
        }

        public static void Divide(ref Vector3 a, ref Vector3 b, out Vector3 @return)
        {
            @return = new Vector3
            {
                X = a.X / b.X,
                Y = a.Y / b.Y,
                Z = a.Z / b.Z
            };
        }

        public static Vector3 Divide(Vector3 a, float divisor)
        {
            float num = 1f / divisor;
            return new Vector3
            {
                X = a.X * num,
                Y = a.Y * num,
                Z = a.Z * num
            };
        }

        public static void Divide(ref Vector3 a, float divisor, out Vector3 @result)
        {
            float num = 1f / divisor;
            @result = new Vector3
            {
                X = a.X * num,
                Y = a.Y * num,
                Z = a.Z * num
            };
        }
    }
}
