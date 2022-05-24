using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2
{
    public class Lesson2 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangleTexture;
        Texture2D circleTexture;
        Rectangle circleRect;
        Rectangle circleRect1;
        Rectangle circleRect2;
        SpriteFont titleFont;
        public Lesson2()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions
            circleRect = new Rectangle(220, 50, 69, 69);
            circleRect1 = new Rectangle(320, 50, 69, 69);
            circleRect2 = new Rectangle(250, 150, 125, 69);

            this.Window.Title = "Lesson 2";
            base.Initialize();
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            rectangleTexture = Content.Load<Texture2D>("Rectangle");
            circleTexture = Content.Load<Texture2D>("Circle");
            titleFont = Content.Load<SpriteFont>("Title");
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Red);
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, new Rectangle(300, 150, 40, 400), Color.White);
            _spriteBatch.Draw(circleTexture, new Vector2(192, 0), Color.White);
            _spriteBatch.Draw(circleTexture, circleRect, Color.Blue);
            _spriteBatch.Draw(circleTexture, circleRect1, Color.Blue);
            _spriteBatch.Draw(circleTexture, circleRect2, Color.Blue);

            _spriteBatch.DrawString(titleFont, "AAAAAAAAAAAAAAAAAAAAA!!!", new Vector2(10, 10), Color.Black);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}