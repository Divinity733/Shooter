using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter.Model
{
    public class Player
    {
        // Animation representing the player
        public Animation playerAnimation;

        // Position of the Player relative to the upper left side of the screen
        public Vector2 position;

        // State of the player
        private bool active;

        // Amount of hit points that player has
        private int health;

        // Get the width of the player ship
        private int width;

        // Get the height of the player ship
        private int height;

        public Animation PlayerAnimation
        {
            get { return playerAnimation; }
            set { playerAnimation = value; }
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // Get the width of the player ship
        public int Width
        {
            get { return PlayerAnimation.FrameWidth; }
        }

        // Get the height of the player ship
        public int Height
        {
            get { return PlayerAnimation.FrameHeight; }
        }

        // Initialize the player
        public void Initialize(Animation animation, Vector2 position)
        {
            PlayerAnimation = animation;

            // Set the starting position of the player around the middle of the screen and to the back
            Position = position;

            // Set the player to be active
            Active = true;

            // Set the player health
            Health = 100;
        }

        // Update the player animation
        public void Update(GameTime gameTime)
        {
            PlayerAnimation.Position = Position;
            PlayerAnimation.Update(gameTime);
        }

        // Draw the player
        public void Draw(SpriteBatch spriteBatch)
        {
            PlayerAnimation.Draw(spriteBatch);
        }
    }
        
}
