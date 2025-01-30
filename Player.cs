using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogamecheatsheet
{
    public class Player : BaseClass
    {
        public Player(Texture2D texture)
            :base(texture, new Microsoft.Xna.Framework.Vector2(350, 190))
        {
            color = Microsoft.Xna.Framework.Color.Green;
        }

        public override void Update()
        {      
            KeyboardState kState = Keyboard.GetState();
            MouseState mState = Mouse.GetState();

            int speed = 5;


            if(kState.IsKeyDown(Keys.W)) 
            {
                position.Y -= speed;
            }
            if(kState.IsKeyDown(Keys.S)) 
            {
                position.Y += speed;
            }
            if(kState.IsKeyDown(Keys.A)) 
            {
                position.X -= speed;
            }
            if(kState.IsKeyDown(Keys.D)) 
            {
                position.X += speed;
            }
            if(kState.IsKeyDown(Keys.R))
            {
                position.X = 350;
                position.Y = 190;
            }

            if(mState.LeftButton==ButtonState.Pressed) 
            {
                
            }
                
            
            
        }
    }
}