namespace Crimson.Maths
{
#if XNA4 || XNA31
    using XnaVector3 = Microsoft.Xna.Framework.Vector3;
#endif

    public partial struct Vector3
    {
        public Vector3(float value)
        {
#if XNA4 || XNA31
            this.InternalVector3 = new XnaVector3();
#endif
            this.X = this.Y = this.Z = value;
        }

        public Vector3(float x, float y, float z)
        {
#if XNA4 || XNA31
            this.InternalVector3 = new XnaVector3();
#endif
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //public Vector3(Vector2 value, float z) // todo dependancy Vector2
        //{
        //    this.X = value.X;
        //    this.Y = value.Y;
        //    this.Z = z;
        //}
    }
}
