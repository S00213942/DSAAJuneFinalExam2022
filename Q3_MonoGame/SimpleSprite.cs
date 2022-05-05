using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprites
{
    public class SimpleSprite
    {
        //var
        public Texture2D Image;
        public Vector2 Position;
        public Rectangle BoundingRect;
        public bool Visible = true;
        internal string name;
        private Texture2D tx;
        private Vector2 pos;

        public SimpleSprite(Texture2D spriteImage,
                            Vector2 startPosition)
        {
            Image = spriteImage;
            Position = startPosition;
            BoundingRect = new Rectangle((int)startPosition.X, (int)startPosition.Y, Image.Width, Image.Height);

        }

        public SimpleSprite(string name, Vector2 pos)
        {
            this.name = name;

            this.Position = pos;
        }

        public string Name { get; internal set; }

        public void draw(SpriteBatch sp)
        {
            if (Visible)//only if visible
                sp.Draw(Image, Position, Color.White);//looks into dict
        }

        public void Move(Vector2 delta)
        {
            Position += delta;
            BoundingRect = new Rectangle((int)Position.X, (int)Position.Y, Image.Width, Image.Height);
            BoundingRect.X = (int)Position.X;
            BoundingRect.Y = (int)Position.Y;
        }
    }
}
