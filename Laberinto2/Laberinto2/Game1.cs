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
        Texture2D Fondo1, Balon1, ParedArriba, ParedAbajo, ParedDe, ParedDe1, ParedLatIz, Pared1, Pared2, Pared3, Pared4, Pared5, Pared6, Pared7, Pared8, Pared9, Pared10, Pared11, Pared12, _YouWin;
        Rectangle Pos_Fondo1, Pos_Balon1, Pos_ParedArriba, Pos_ParedAbajo, Pos_ParedDe, Pos_ParedDe1, Pos_ParedLatIz, Pos_Pared1, Pos_Pared2, Pos_Pared3, Pos_Pared4, Pos_Pared5, Pos_Pared6, Pos_Pared7, Pos_Pared8, Pos_Pared9, Pos_Pared10, Pos_Pared11, Pos_Pared12, Pos_Youwin;
        //-------------------------------------------------//
        //Nivel 2
        Texture2D Inicio, Fondo, Balon, Pared_lateral, Pared_Abajo, Pared_Arriba, Pared_LateralIz, Pared_LateralDe, Pared_2, Pared_3, Pared_4, Pared_5, Pared_6, Pared_7, Pared_8, Pared_9, Pared_10, Pared_11, Pared_12, Pared13, Pared14, Pared15, Pared16, Pared17, Pared18, Pared19;
        Texture2D Pared20, GameOver, Pared21, Pared22, Pared23, Pared24, Pared25, Pared26, Pared27, Pared28, Pared29, Pared30, Pared31;
        Rectangle Pos_Inicio, Pos_Fondo, Posicion_ParedAbajo, Posicion_Balon, Posicion_Pared1, Posicion_ParedArriba, Posicion_ParedLateralIz, Posicion_ParedLateralDe, Posicion_Pared2, Pos_Pared21, Pos_Pared22, Pos_Pared23, Pos_Pared24, Pos_Pared25;
        Rectangle Posicion_Pared3, Posicion_Pared4, Posicion_Pared5, Posicion_Pared6, Posicion_Pared7, Posicion_Pared8, Posicion_Pared9, Posicion_Pared10, Posicion_Pared11, Pos_Pared26, Pos_Pared27, Pos_Pared28, Pos_Pared29, Pos_Pared30, Pos_Pared31;
        Rectangle Posicion_Pared12, Posicion_Pared13, Posicion_Pared14, Posicion_Pared15, Posicion_Pared16, Posicion_Pared17, Posicion_Pared18, Pos_Pared19, Pos_Pared20, Pos_Over;
        //---------------------------------------------------//
        //Variables
        int VelocidadBalon;
        bool inicio;
        bool nivel2;
        bool limite;
        bool youWin;
        //--------------------------------------------------------//
        //Funciones
        void Nivel1Teclado1()
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
        void NivelTeclado2()
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
        void Nivel2Teclado1()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Posicion_Balon.X -= VelocidadBalon;
            }
            //Mover hacia la derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Posicion_Balon.X += VelocidadBalon;
            }
            //Mover hacia arriba
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Posicion_Balon.Y -= VelocidadBalon;
            }
            //Mover hacia abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Posicion_Balon.Y += VelocidadBalon;
            }
        }
        void Nivel2Teclado2()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Posicion_Balon.X += VelocidadBalon;
            }
            //Mover hacia la derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                Posicion_Balon.X -= VelocidadBalon;
            }
            //Mover hacia arriba
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                Posicion_Balon.Y += VelocidadBalon;
            }
            //Mover hacia abajo
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                Posicion_Balon.Y -= VelocidadBalon;
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
            inicio = false;
            nivel2 = false;
            limite = false;
            youWin = false;
            RectangulosNivel1();
            RectangulosNivel2();
            base.Initialize();
        }

        private void RectangulosNivel2()
        {
            Pos_Inicio = new Rectangle(0, 0, 800, 480);
            Pos_Fondo = new Rectangle(0, 0, 800, 480);
            Posicion_Balon = new Rectangle(0, 60, 35, 35);
            Posicion_Pared1 = new Rectangle(0, 100, 60, 20);
            Posicion_ParedAbajo = new Rectangle(0, 460, 800, 20);
            Posicion_ParedArriba = new Rectangle(0, 35, 800, 20);
            Posicion_ParedLateralIz = new Rectangle(0, 105, 20, 400);
            Posicion_ParedLateralDe = new Rectangle(780, 35, 20, 375);
            Posicion_Pared2 = new Rectangle(60, 100, 20, 100);
            Posicion_Pared3 = new Rectangle(130, 95, 20, 105);
            Posicion_Pared4 = new Rectangle(60, 180, 90, 20);
            Posicion_Pared5 = new Rectangle(60, 240, 20, 45);
            Posicion_Pared6 = new Rectangle(60, 280, 100, 20);
            Posicion_Pared7 = new Rectangle(140, 280, 20, 180);
            Posicion_Pared8 = new Rectangle(0, 345, 90, 20);
            Posicion_Pared9 = new Rectangle(80, 345, 20, 75);
            Posicion_Pared10 = new Rectangle(220, 115, 20, 305);
            Posicion_Pared11 = new Rectangle(220, 35, 20, 150);
            Posicion_Pared12 = new Rectangle(220, 155, 80, 20);
            Posicion_Pared13 = new Rectangle(290, 105, 20, 170);
            Posicion_Pared14 = new Rectangle(290, 335, 20, 190);
            Posicion_Pared15 = new Rectangle(290, 335, 80, 20);
            Posicion_Pared16 = new Rectangle(350, 395, 20, 65);
            Posicion_Pared17 = new Rectangle(350, 35, 20, 240);
            Posicion_Pared18 = new Rectangle(350, 265, 70, 20);
            Pos_Pared19 = new Rectangle(420, 95, 20, 190);
            Pos_Pared20 = new Rectangle(420, 335, 20, 80);
            Pos_Pared21 = new Rectangle(420, 400, 120, 20);
            Pos_Pared22 = new Rectangle(420, 335, 100, 20);
            Pos_Pared23 = new Rectangle(500, 35, 20, 300);
            Pos_Pared24 = new Rectangle(560, 95, 20, 255);
            Pos_Pared25 = new Rectangle(560, 340, 80, 20);
            Pos_Pared26 = new Rectangle(620, 340, 20, 120);
            Pos_Pared27 = new Rectangle(560, 95, 170, 20);
            Pos_Pared28 = new Rectangle(710, 95, 20, 195);
            Pos_Pared29 = new Rectangle(620, 270, 90, 20);
            Pos_Pared30 = new Rectangle(620, 155, 20, 120);
            Pos_Pared31 = new Rectangle(700, 370, 80, 20);
            Pos_Over = new Rectangle(0, 0, 800, 480);
        }
        private void RectangulosNivel1()
        {
            Pos_Fondo1 = new Rectangle(0, 0, 800, 480);
            Pos_Balon1 = new Rectangle(2, 55, 45, 45);
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
            Pos_Youwin = new Rectangle(0, 0, 800, 460);
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
            TexturasNivel2();

            // TODO: use this.Content to load your game content here
        }

        private void TexturasNivel2()
        {
            Fondo = Content.Load<Texture2D>("Arco");
            Balon = Content.Load<Texture2D>("Balon");
            Pared_lateral = Content.Load<Texture2D>("Pared1");
            Pared_Abajo = Content.Load<Texture2D>("Pared_Abajo");
            Pared_Arriba = Content.Load<Texture2D>("Pared_Arriba");
            Pared_LateralIz = Content.Load<Texture2D>("Pared_lateral");
            Pared_LateralDe = Content.Load<Texture2D>("Pared_lateral2");
            Pared_2 = Content.Load<Texture2D>("Pared2");
            Pared_3 = Content.Load<Texture2D>("Pared3");
            Pared_4 = Content.Load<Texture2D>("Pared4");
            Pared_5 = Content.Load<Texture2D>("Pared5");
            Pared_6 = Content.Load<Texture2D>("Pared6");
            Pared_7 = Content.Load<Texture2D>("Pared7");
            Pared_8 = Content.Load<Texture2D>("Pared8");
            Pared_9 = Content.Load<Texture2D>("Pared9");
            Pared_10 = Content.Load<Texture2D>("Pared10");
            Pared_11 = Content.Load<Texture2D>("Pared11");
            Pared_12 = Content.Load<Texture2D>("Pared12");
            Pared13 = Content.Load<Texture2D>("Pared13");
            Pared14 = Content.Load<Texture2D>("Pared14");
            Pared15 = Content.Load<Texture2D>("Pared15");
            Pared16 = Content.Load<Texture2D>("Pared16");
            Pared17 = Content.Load<Texture2D>("Pared17");
            Pared18 = Content.Load<Texture2D>("Pared18");
            Pared19 = Content.Load<Texture2D>("Pared19");
            Pared20 = Content.Load<Texture2D>("Pared20");
            Pared21 = Content.Load<Texture2D>("Pared21");
            Pared22 = Content.Load<Texture2D>("Pared22");
            Pared23 = Content.Load<Texture2D>("Pared23");
            Pared24 = Content.Load<Texture2D>("Pared24");
            Pared25 = Content.Load<Texture2D>("Pared25");
            Pared26 = Content.Load<Texture2D>("Pared26");
            Pared27 = Content.Load<Texture2D>("Pared27");
            Pared28 = Content.Load<Texture2D>("Pared28");
            Pared29 = Content.Load<Texture2D>("Pared29");
            Pared30 = Content.Load<Texture2D>("Pared30");
            Pared31 = Content.Load<Texture2D>("Pared31");
            GameOver = Content.Load<Texture2D>("GameOver");
            Inicio = Content.Load<Texture2D>("Estadio");
        }
        private void TexturasNivel1()
        {
            Fondo1 = Content.Load<Texture2D>("Fondo");
            Balon1 = Content.Load<Texture2D>("Oficial_Balon");
            ParedArriba = Content.Load<Texture2D>("Pared_Arriba1");
            ParedAbajo = Content.Load<Texture2D>("Pared_Abajo1");
            ParedLatIz = Content.Load<Texture2D>("Pared_Lateral1");
            ParedDe = Content.Load<Texture2D>("Pared_De1");
            ParedDe1 = Content.Load<Texture2D>("Pared_De2");
            Pared1 = Content.Load<Texture2D>("Pared_1");
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
            _YouWin = Content.Load<Texture2D>("YouWin");
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
            //---------------------------------------//
            //Nivel 1
            Nivel1Teclado1();
            InicioJuego();
            ColisionNivel1();
            //---------------------------------------//
            //Nivel2
            Nivel2();
            Youwin();
            //-----------------------------------------//
            base.Update(gameTime);
        }

        private void Youwin()
        {
            if (Posicion_Balon.X >= 800)
            {
                youWin = true;
            }
        }
        private void Nivel2()
        {
            if (Pos_Balon1.X >= 800)
            {
                Nivel2Teclado1();
                nivel2 = true;
                ColisionNivel2();

            }
        }
        private void InicioJuego()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                inicio = true;
            }
        }
        private void ColisionNivel2()
        {
            if (Posicion_Balon.Intersects(Posicion_Pared1) || Posicion_Balon.Intersects(Posicion_Pared14) || Posicion_Balon.Intersects(Posicion_Pared16) || Posicion_Balon.Intersects(Pos_Pared20) || Posicion_Balon.Intersects(Pos_Pared21) || Posicion_Balon.Intersects(Pos_Pared22) || Posicion_Balon.Intersects(Pos_Pared24) ||
           Posicion_Balon.Intersects(Posicion_Pared17) || Posicion_Balon.Intersects(Pos_Pared19) || Posicion_Balon.Intersects(Posicion_Pared18) || Posicion_Balon.Intersects(Posicion_Pared15) || Posicion_Balon.Intersects(Posicion_ParedAbajo) || Posicion_Balon.Intersects(Posicion_ParedArriba) || Posicion_Balon.Intersects(Pos_Pared25)
           || Posicion_Balon.Intersects(Posicion_ParedLateralIz) || Posicion_Balon.Intersects(Posicion_ParedLateralDe) || Posicion_Balon.Intersects(Posicion_Pared2) || Posicion_Balon.Intersects(Pos_Pared23) || Posicion_Balon.Intersects(Pos_Pared26) || Posicion_Balon.Intersects(Pos_Pared27) || Posicion_Balon.Intersects(Pos_Pared28))
            {
                Nivel2Teclado2();
            }

            if (Posicion_Balon.Intersects(Posicion_Pared3) || Posicion_Balon.Intersects(Posicion_Pared4) || Posicion_Balon.Intersects(Posicion_Pared5) || Posicion_Balon.Intersects(Posicion_Pared6) || Posicion_Balon.Intersects(Pos_Pared29) || Posicion_Balon.Intersects(Pos_Pared30) || Posicion_Balon.Intersects(Pos_Pared31)
                || Posicion_Balon.Intersects(Posicion_Pared7) || Posicion_Balon.Intersects(Posicion_Pared8) || Posicion_Balon.Intersects(Posicion_Pared9) || Posicion_Balon.Intersects(Posicion_Pared10)
                || Posicion_Balon.Intersects(Posicion_Pared11) || Posicion_Balon.Intersects(Posicion_Pared12) || Posicion_Balon.Intersects(Posicion_Pared13))
            {
                Nivel2Teclado2();
            }
        }
        private void ColisionNivel1()
        {
            if (Pos_Balon1.Intersects(Pos_ParedArriba) || Pos_Balon1.Intersects(Pos_ParedLatIz) || Pos_Balon1.Intersects(Pos_ParedAbajo) || Pos_Balon1.Intersects(Pos_ParedDe) || Pos_Balon1.Intersects(Pos_ParedDe1) || Pos_Balon1.Intersects(Pos_Pared1) || Pos_Balon1.Intersects(Pos_Pared2)
                || Pos_Balon1.Intersects(Pos_Pared3) || Pos_Balon1.Intersects(Pos_Pared4) || Pos_Balon1.Intersects(Pos_Pared5) || Pos_Balon1.Intersects(Pos_Pared6) || Pos_Balon1.Intersects(Pos_Pared7) || Pos_Balon1.Intersects(Pos_Pared8) || Pos_Balon1.Intersects(Pos_Pared9)
                || Pos_Balon1.Intersects(Pos_Pared10) || Pos_Balon1.Intersects(Pos_Pared11) || Pos_Balon1.Intersects(Pos_Pared12))
            {
                NivelTeclado2();
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
            NivelDos();
            spriteBatch.DrawString(tiempo, "Tiempo:" + (gameTime.TotalGameTime.Minutes) + ":" + (gameTime.TotalGameTime.Seconds), Pos_Tiempo, Color.Black);
            YouWin_();
            Game_Over(gameTime);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void YouWin_()
        {
            if (youWin == true)
            {
                spriteBatch.Draw(_YouWin, Pos_Youwin, Color.White);
            }
        }
        private void Game_Over(GameTime gameTime)
        {
            if (gameTime.TotalGameTime.TotalSeconds >= 60)
            {
                limite = true;
            }
            if (limite == true)
            {
                spriteBatch.Draw(GameOver, Pos_Over, Color.White);
            }
        }
        private void NivelDos()
        {
            if (nivel2 == true)
            {
                spriteBatch.Draw(Fondo, Pos_Fondo, Color.White);
                spriteBatch.Draw(Balon, Posicion_Balon, Color.White);
                spriteBatch.Draw(Pared_lateral, Posicion_Pared1, Color.Black);
                spriteBatch.Draw(Pared_Abajo, Posicion_ParedAbajo, Color.Black);
                spriteBatch.Draw(Pared_Arriba, Posicion_ParedArriba, Color.Black);
                spriteBatch.Draw(Pared_LateralIz, Posicion_ParedLateralIz, Color.Black);
                spriteBatch.Draw(Pared_LateralDe, Posicion_ParedLateralDe, Color.Black);
                spriteBatch.Draw(Pared_2, Posicion_Pared2, Color.Black);
                spriteBatch.Draw(Pared_3, Posicion_Pared3, Color.Black);
                spriteBatch.Draw(Pared_4, Posicion_Pared4, Color.Black);
                spriteBatch.Draw(Pared_5, Posicion_Pared5, Color.Black);
                spriteBatch.Draw(Pared_6, Posicion_Pared6, Color.Black);
                spriteBatch.Draw(Pared_7, Posicion_Pared7, Color.Black);
                spriteBatch.Draw(Pared_8, Posicion_Pared8, Color.Black);
                spriteBatch.Draw(Pared_9, Posicion_Pared9, Color.Black);
                spriteBatch.Draw(Pared_10, Posicion_Pared10, Color.Black);
                spriteBatch.Draw(Pared_11, Posicion_Pared11, Color.Black);
                spriteBatch.Draw(Pared_12, Posicion_Pared12, Color.Black);
                spriteBatch.Draw(Pared13, Posicion_Pared13, Color.Black);
                spriteBatch.Draw(Pared14, Posicion_Pared14, Color.Black);
                spriteBatch.Draw(Pared15, Posicion_Pared15, Color.Black);
                spriteBatch.Draw(Pared16, Posicion_Pared16, Color.Black);
                spriteBatch.Draw(Pared17, Posicion_Pared17, Color.Black);
                spriteBatch.Draw(Pared18, Posicion_Pared18, Color.Black);
                spriteBatch.Draw(Pared19, Pos_Pared19, Color.Black);
                spriteBatch.Draw(Pared20, Pos_Pared20, Color.Black);
                spriteBatch.Draw(Pared21, Pos_Pared21, Color.Black);
                spriteBatch.Draw(Pared22, Pos_Pared22, Color.Black);
                spriteBatch.Draw(Pared23, Pos_Pared23, Color.Black);
                spriteBatch.Draw(Pared24, Pos_Pared24, Color.Black);
                spriteBatch.Draw(Pared25, Pos_Pared25, Color.Black);
                spriteBatch.Draw(Pared26, Pos_Pared26, Color.Black);
                spriteBatch.Draw(Pared27, Pos_Pared27, Color.Black);
                spriteBatch.Draw(Pared28, Pos_Pared28, Color.Black);
                spriteBatch.Draw(Pared29, Pos_Pared29, Color.Black);
                spriteBatch.Draw(Pared30, Pos_Pared30, Color.Black);
                spriteBatch.Draw(Pared31, Pos_Pared31, Color.Black);
            }
            
        }
        private void NivelUno()
        {
            if(inicio == true)
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
            else
            {
                spriteBatch.Draw(Inicio, Pos_Inicio, Color.White);
            }
           
        }
    }
}
