namespace Crimson.Maths.Specs
{
    using Machine.Specifications;

    public abstract class with_a_Vector3
    {
        protected static Vector3 vector;

        private Establish context = () =>
        {
            vector = new Vector3(3,4,5);
        };
    }

    [Subject(typeof(Vector3), "Casting")]
    public class when_casting_a_Crimson_Vector3 : with_a_Vector3
    {
        private static Microsoft.Xna.Framework.Vector3 XnaVector3;
        private static SlimDX.Vector3 SlimVector3;
        private static Vector3 BackXna, BackSlim;

        private Because of = () =>
        {
            XnaVector3 = (Microsoft.Xna.Framework.Vector3)vector;
            SlimVector3 = (SlimDX.Vector3) vector;
            BackXna = (Vector3)XnaVector3;
            BackSlim = (Vector3)SlimVector3;
        };

        private It should_correctly_cast_crimson_vectors_to_xna_vectors = () =>
        {
            XnaVector3.ShouldEqual(vector.XnaVector3);
        };

        private It should_correctly_cast_xna_vectors_to_crimson_vectors = () =>
        {
            BackXna.ShouldEqual(vector);
        };

        private It should_correctly_cast_crimson_vectors_to_slimDX_vectors = () =>
        {
            SlimVector3.ShouldEqual(vector.SlimDXVector3);
        };

        private It should_correctly_cast_slimDX_vectors_to_crimson_vectors = () =>
        {
            BackSlim.ShouldEqual(vector);
        };
    }
}
