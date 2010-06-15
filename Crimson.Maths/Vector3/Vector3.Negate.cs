namespace Crimson.Maths
{
    public partial struct Vector3
    {
        public static Vector3 operator -(Vector3 vector3)
        {
            return new Vector3
            {
                X = -vector3.X,
                Y = -vector3.Y,
                Z = -vector3.Z
            };
        }

        public static Vector3 Negate(Vector3 vector3)
        {
            return new Vector3
            {
                X = -vector3.X,
                Y = -vector3.Y,
                Z = -vector3.Z
            };
        }

        public static void Negate(ref Vector3 vector3, out Vector3 result)
        {
            result = new Vector3
            {
                X = -vector3.X,
                Y = -vector3.Y,
                Z = -vector3.Z
            };
        }
    }
}
