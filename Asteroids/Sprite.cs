using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Storage;

namespace Asteroids_Clone //Makes sure the class is setup under the right project name
{
    class Sprite //Initialises the class
    {
        Texture2D texture;

        Vector2 position;
        Vector2 centre;
        Vector2 velocity;

        float rotation;
        float scale;

        bool alive;
        int index;

        public Sprite(Texture2D texture) // This subroutine is used to pass textures to in the main game for processing here
        {
            this.texture = texture;

            position = Vector2.Zero;
            centre = new Vector2(texture.Width / 2, texture.Height / 2);
            velocity = Vector2.Zero;

            Rotation = 0.0f;

            Scale = 1.0f;

            alive = false;

            index = 0;
        }

        public Texture2D Texture //Property to return the texture of a sprite that is currently being accessed
        {
            get { return texture; }
            set { texture = value; }
        }

        public Vector2 Position //Property to return the position of a sprite that is currently being accessed
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 Centre //Property to return the centre of a sprite that is currently being accessed
        {
            get { return centre; }
        }

        public Vector2 Velocity //Property to return the velocity of a sprite that is currently being accessed
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public float Rotation //Property to return the rotation of a sprite that is currently being accessed
        {
            get { return rotation; }
            set
            {
                rotation = value;
                if (rotation < -MathHelper.TwoPi)
                    rotation = MathHelper.TwoPi;
                if (rotation > MathHelper.TwoPi)
                    rotation = -MathHelper.TwoPi;
            }
        }

        public float Scale //Property to return the scale of a sprite that is currently being accessed
        {
            get { return scale; }
            set { scale = value; }
        }

        public bool Alive //Property to return the state of a sprite (alive/dead) that is currently being accessed
        {
            get { return alive; }
        }

        public int Index //Used to store if a sprite has multiple different textures loaded at once & the locations of them
        {
            get { return index; }
            set { index = value; }
        }

        public int Width //Property to return the width of a sprite that is currently being accessed
        {
            get { return texture.Width; }
        }

        public int Height //Property to return the height of a sprite that is currently being accessed
        {
            get { return texture.Height; }
        }

        public void Create() //Subroutine used to create the sprite when it is called
        {
            alive = true;
        }

        public void Kill() //Subroutine used to destroy the sprite when it is called
        {
            alive = false;
        }
    }
}

