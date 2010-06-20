using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Vector3 = Crimson.Maths.Vector3;
using XnaVector3 = Microsoft.Xna.Framework.Vector3;

namespace Xna4Demo
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;
        private Vector3 a, b, c;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            a = new Vector3 {X = 10, Y = 11, Z = 12};

            b = new Vector3();
            b.X = b.Y = b.Z = 1;

            // c = Vector3.Add(a, b);
            c.XnaVector3 = a.XnaVector3 + b.XnaVector3; // <-- interesting

            Vector3 vec = new Vector3(1, 2, 3); // testing type casting
            XnaVector3 test = vec;
            Vector3 test2 = test;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            font = Content.Load<SpriteFont>(@"Fonts/Font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            {
                this.Exit();
            }


            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            XnaVector3 a = this.a;
            XnaVector3 b = this.b;

            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Vector A: " + a, new Vector2(20, 20), Color.White);
            spriteBatch.DrawString(font, "Vector B: " + b, new Vector2(20, 40), Color.White);
            spriteBatch.DrawString(font, "______________________________", new Vector2(20, 60), Color.White);
            spriteBatch.DrawString(font, "Vector A+B: " + c, new Vector2(20, 80), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
