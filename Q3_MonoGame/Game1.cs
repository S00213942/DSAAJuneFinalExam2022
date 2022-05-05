using System.Collections.Generic;
using Sprites;
using System;
using Manager.AudioPlayer;
using Manager.Load;
using Microsoft.Xna.Framework.Audio;
using Engine.Engines;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tracker.WebAPIClient;

namespace Q3_MonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Dictionary<string, SimpleSprite> objSprite;
        //Random random;
        List<string> objectList;
        List<string> soundList;
        SoundEffectInstance sound;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            ActivityAPIClient.Track(StudentID: "S00213942", StudentName: "Emmet Carroll", activityName: "DSAA Week 6 Labs 2022", Task: "Week 6 Lab 1 playing sounds.");
            new InputEngine(this);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            //random = new Random();
            //object sprite loaded
            objectList = new List<string>()
            { "Object01",
               "Object02",
                "Object03",
                 "Object04",
                  "Object05",
                   "Object06",
            };
            soundList = new List<string>()
            {
                "Object01",
                 "Object01",
                  "Object01",
                   "Object01",
                    "Object01",
                     "Object01",
            };


            objSprite = new Dictionary<string, SimpleSprite>();
            //adding badges to dictionary

            Vector2 StartPos = new Vector2(20, 20);
            foreach (string names in objectList)
            {
                objSprite.Add(names, new SimpleSprite(Content.Load<Texture2D>("Textures/" + names), new Vector2(StartPos.X += 50, StartPos.Y += 50)));
                AudioManager.SoundEffects = Loader.ContentLoad<SoundEffect>(Content, "Sounds");

            }


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            //Playing sound on mouse click
            foreach (string names in objectList)
            {
                if (objSprite[names].BoundingRect.Contains(InputEngine.MousePosition) && InputEngine.IsMouseLeftClick())
                {
                    AudioManager.Play(ref sound, names);
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Maroon);
            _spriteBatch.Begin();
            foreach (string names in objectList)
            {
                objSprite[names].draw(_spriteBatch);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}