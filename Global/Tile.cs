using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Global
{
    public class Tile
        : IDrawable
    {
        public Rectangle Position { get; set; }

        public Texture2D Image { get; set; }

        public bool Collidable { get; set; }
        public bool Visible { get; set; }

        public Color Tint { get; set; }

        public Tile()
        {
            Tint = Color.White;
            Visible = true;
            Collidable = true;
        }

        public void Draw(SpriteBatch Batch)
        {
            if (Visible)
            {
                Batch.Draw(Image, Position, Tint);
            }
        }

        public string Serialise()
        {
            StringBuilder Builder = new StringBuilder();

            Builder.Append(Position.ToString());
            Builder.Append('\0');
            Builder.Append(Image.ToString());
            Builder.Append('\0');
            Builder.Append(Collidable ? 1 : 0);
            Builder.Append('\0');
            Builder.Append(Visible ? 1 : 0);
            Builder.Append('\0');
            Builder.Append(Tint.ToString());

            return Builder.ToString();
        }
        public void Deserialise(string From)
        {

        }
    }
}
