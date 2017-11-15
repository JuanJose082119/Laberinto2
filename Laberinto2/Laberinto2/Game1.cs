using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Laberinto2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //------------------------------------------------//
        //Nivel 1
        SpriteFont tiempo;
        Vector2 Pos_Tiempo;
        Texture2D Fondo1, Balon1, ParedArriba, ParedAbajo, ParedDe, ParedDe1, ParedLatIz, Pared1, Pared2, Pared3, Pared4, Pared5, Pared6, Pared7, Pared8, Pared9, Pared10, Pared11, Pared12;
        Rectangle Pos_Fondo1, Pos_Balon1, Pos_ParedArriba, Pos_ParedAbajo, Pos_ParedDe, Pos_ParedDe1, Pos_ParedLatIz, Pos_Pared1, Pos_Pared2, Pos_Pared3, Pos_Pared4, Pos_Pared5, Pos_Pared6, Pos_Pared7, Pos_Pared8, Pos_Pared9, Pos_Pared10, Pos_Pared11, Pos_Pared12;
        //-------------------------------------------------//
        //Variables
        int VelocidadBalon;

        //--------------------------------------------------------//
        //Funciones
        void Teclado1()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Pos_Balon1.X -= VelocidadBalon;
            }
            //Mover hacia la derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Pos_Balon1.X += VelocidadBalon;
            }
            //Mover hacia arriba
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Pos_Balon1.Y -= VelocidadBalon;
            }
            //Mover hacia abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Pos_Balon1.Y += VelocidadBalon;
            }
        }
        void Teclado2()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Pos_Balon1.X += VelocidadBalon;
            }
            //Mover hacia la derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Pos_Balon1.X -= VelocidadBalon;
            }
            //Mover hacia arriba
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Pos_Balon1.Y += VelocidadBalon;
            }
            //Mover hacia abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Pos_Balon1.Y -= VelocidadBalon;
            }
        }
        //--------------------------------------------------------//

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            VelocidadBalon = 4;
            RectangulosNivel1();

            base.Initialize();
        }

        private void RectangulosNivel1()
        {
            Pos_Fondo1 = new Rectangle(0, 0, 800, 480);
            Pos_Balon1 = new Rectangle(2, 55, 40, 40);
            Pos_ParedArriba = new Rectangle(0, 35, 800, 20);
            Pos_ParedAbajo = new Rectangle(0, 460, 800, 20);
            Pos_ParedLatIz = new Rectangle(0, 105, 20, 400);
            Pos_ParedDe = new Rectangle(780, 35, 20, 185);
            Pos_ParedDe1 = new Rectangle(780, 275, 30, 200);
            Pos_Pared1 = new Rectangle(0, 200, 320, 20);
            Pos_Pared2 = new Rectangle(300, 120, 20, 80);
            Pos_Pared3 = new Rectangle(160, 35, 20, 90);
            Pos_Pared4 = new Rectangle(300, 120, 200, 20);
            Pos_Pared5 = new Rectangle(500, 200, 280, 20);
            Pos_Pared6 = new Rectangle(640, 120, 20, 80);
            Pos_Pared7 = new Rectangle(500, 200, 20, 80);
            Pos_Pared8 = new Rectangle(160, 280, 360, 20);
            Pos_Pared9 = new Rectangle(160, 280, 20, 90);
            Pos_Pared10 = new Rectangle(640, 275, 20, 90);
            Pos_Pared11 = new Rectangle(300, 360, 360, 20);
            Pos_Pared12 = new Rectangle(640, 275, 140, 20);
            Pos_Tiempo = new Vector2(380, 5);
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            TexturasNivel1();

            // TODO: use this.Content to load your game content here
        }

        private void TexturasNivel1()
        {
            Fondo1 = Content.Load<Texture2D>("Fondo");
            Balon1 = Content.Load<Texture2D>("Balon_1");
            ParedArriba = Content.Load<Texture2D>("Pared_Arriba");
            ParedAbajo = Content.Load<Texture2D>("Pared_Abajo1");
            ParedLatIz = Content.Load<Texture2D>("Pared_Lateral1");
            ParedDe = Content.Load<Texture2D>("Pared_De1");
            ParedDe1 = Content.Load<Texture2D>("Pared_De2");
            Pared1 = Content.Load<Texture2D>("Pared1");
            Pared2 = Content.Load<Texture2D>("Pared_2");
            Pared3 = Content.Load<Texture2D>("Pared_3");
            Pared4 = Content.Load<Texture2D>("Pared_4");
            Pared5 = Content.Load<Texture2D>("Pared_5");
            Pared6 = Content.Load<Texture2D>("Pared_6");
            Pared7 = Content.Load<Texture2D>("Pared_7");
            Pared8 = Content.Load<Texture2D>("Pared_8");
            Pared9 = Content.Load<Texture2D>("Pared_9");
            Pared10 = Content.Load<Texture2D>("Pared_10");
            Pared11 = Content.Load<Texture2D>("Pared_11");
            Pared12 = Content.Load<Texture2D>("Pared_12");
            tiempo = Content.Load<SpriteFont>("tiempo");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //Nivel 1
            Teclado1();
            ColisionNivel1();

            base.Update(gameTime);
        }

        private void ColisionNivel1()
        {
            if (Pos_Balon1.Intersects(Pos_ParedArriba) || Pos_Balon1.Intersects(Pos_ParedLatIz) || Pos_Balon1.Intersects(Pos_ParedAbajo) || Pos_Balon1.Intersects(Pos_ParedDe) || Pos_Balon1.Intersects(Pos_ParedDe1) || Pos_Balon1.Intersects(Pos_Pared1) || Pos_Balon1.Intersects(Pos_Pared2)
                || Pos_Balon1.Intersects(Pos_Pared3) || Pos_Balon1.Intersects(Pos_Pared4) || Pos_Balon1.Intersects(Pos_Pared5) || Pos_Balon1.Intersects(Pos_Pared6) || Pos_Balon1.Intersects(Pos_Pared7) || Pos_Balon1.Intersects(Pos_Pared8) || Pos_Balon1.Intersects(Pos_Pared9)
                || Pos_Balon1.Intersects(Pos_Pared10) || Pos_Balon1.Intersects(Pos_Pared11) || Pos_Balon1.Intersects(Pos_Pared12))
            {
                Teclado2();
            }
        }



        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
             spriteBatch.Begin();
            NivelUno();
            spriteBatch.DrawString(tiempo, "Tiempo:" + (gameTime.TotalGameTime.Minutes) + ":" + (gameTime.TotalGameTime.Seconds), Pos_Tiempo, Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
        private void NivelUno()
        {
            spriteBatch.Draw(Fondo1, Pos_Fondo1, Color.White);
            spriteBatch.Draw(Balon1, Pos_Balon1, Color.White);
            spriteBatch.Draw(ParedArriba, Pos_ParedArriba, Color.Black);
            spriteBatch.Draw(ParedAbajo, Pos_ParedAbajo, Color.Black);
            spriteBatch.Draw(ParedLatIz, Pos_ParedLatIz, Color.Black);
            spriteBatch.Draw(ParedDe, Pos_ParedDe, Color.Black);
            spriteBatch.Draw(ParedDe1, Pos_ParedDe1, Color.Black);
            spriteBatch.Draw(Pared1, Pos_Pared1, Color.Black);
            spriteBatch.Draw(Pared2, Pos_Pared2, Color.Black);
            spriteBatch.Draw(Pared3, Pos_Pared3, Color.Black);
            spriteBatch.Draw(Pared4, Pos_Pared4, Color.Black);
            spriteBatch.Draw(Pared5, Pos_Pared5, Color.Black);
            spriteBatch.Draw(Pared6, Pos_Pared6, Color.Black);
            spriteBatch.Draw(Pared7, Pos_Pared7, Color.Black);
            spriteBatch.Draw(Pared8, Pos_Pared8, Color.Black);
            spriteBatch.Draw(Pared9, Pos_Pared9, Color.Black);
            spriteBatch.Draw(Pared10, Pos_Pared10, Color.Black);
            spriteBatch.Draw(Pared11, Pos_Pared11, Color.Black);
            spriteBatch.Draw(Pared12, Pos_Pared12, Color.Black);
        }
    }
}
