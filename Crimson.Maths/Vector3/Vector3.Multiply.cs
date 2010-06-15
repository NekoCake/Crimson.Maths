namespace Crimson.Maths
{
    public partial struct Vector3
    {
        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X * b.X,
                Y = a.Y * b.Y,
                Z = a.Z * b.Z
            };
        }

        public static Vector3 operator *(Vector3 a, float scaler)
        {
            return new Vector3
            {
                X = a.X * scaler,
                Y = a.Y * scaler,
                Z = a.Z * scaler
            };
        }

        public static Vector3 operator *(float scaler, Vector3 a)
        {
            return new Vector3
            {
                X = a.X * scaler,
                Y = a.Y * scaler,
                Z = a.Z * scaler
            };
        }

        public static Vector3 Multiply(Vector3 a, Vector3 b)
        {
            return new Vector3
            {
                X = a.X * b.X,
                Y = a.Y * b.Y,
                Z = a.Z * b.Z
            };
        }

        public static void Multiply(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result = new Vector3
            {
                X = a.X * b.X,
                Y = a.Y * b.Y,
                Z = a.Z * b.Z
            };
        }

        public static Vector3 Multiply(Vector3 a, float scaler)
        {
            return new Vector3
            {
                X = a.X * scaler,
                Y = a.Y * scaler,
                Z = a.Z * scaler
            };
        }

        public static void Multiply(ref Vector3 a, float scaler, out Vector3 result)
        {
            result = new Vector3
            {
                X = a.X * scaler,
                Y = a.Y * scaler,
                Z = a.Z * scaler
            };
        }
    }
}
