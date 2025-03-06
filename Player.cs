using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1.Effects;
using SharpDX.Direct3D9;
using SharpDX.MediaFoundation;

namespace monogamecheatsheet
{
    public class Player : BaseClass
    {
        private MouseState oldState;
        private float stamina = 100;
        private float rotation;
        private Vector2 scale;

        public Player(Texture2D texture)
            :base(texture, new Microsoft.Xna.Framework.Vector2(350, 190))
        {
            color = Microsoft.Xna.Framework.Color.Green;
            scale.X = 1;
            scale.Y = 1;
        }
        

        public override void Update()
        {      
            KeyboardState kState = Keyboard.GetState();
            MouseState mState = Mouse.GetState();
            Vector2 direction = new Vector2(0,0);
            



            int speed = 2;


            if(kState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.W)) 
            {
                direction.Y -= 1;
            }
            if(kState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.S)) 
            {
                direction.Y += 1;
            }
            if(kState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.A)) 
            {
                direction.X -= 1;
            }
            if(kState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.D)) 
            {
                direction.X += 1;
            }
            if(kState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.R))
            {
                position.X = 350;
                position.Y = 190;
            }
            if(kState.IsKeyDown(Microsoft.Xna.Framework.Input.Keys.LeftShift)) 
            {
                stamina--;
                if(stamina > 0){
                    speed = speed*2;
                }                       
            }
            else{
                if(stamina < 100){
                    stamina++;
                }
            }

            if(direction != Vector2.Zero){
                direction.Normalize();
            }
            position+=direction * speed;

            if(mState.LeftButton == ButtonState.Pressed && oldState.LeftButton == ButtonState.Released) 
            {
                Vector2 bulletDirection = mState.Position.ToVector2() - position;
                bulletDirection.Normalize();

                BulletSystem.Instance.SummonBullet(position, bulletDirection);
            }

            rotation = (float)-(Math.Atan2((position.X-mState.X), (position.Y-mState.Y)))+MathF.PI/2;
                
            
            oldState = mState;
        }

        public Vector2 GetPosition(){
            return position;
        }



        public override void Draw(SpriteBatch spriteBatch)
        {
            rectangle = new Rectangle((int)(position.X - 50), (int)(position.Y - 50) ,30, 30);

            //spriteBatch.Draw(texture, rectangle, color);
            spriteBatch.Draw(texture, rectangle, null, Color.White, rotation,new Vector2(texture.Width/2,texture.Height/2), SpriteEffects.None,0 );
            //spriteBatch.Draw(bulletImage, position, sourceRectangle,Color.White, (float)((Math.Atan2(direction.Y,direction.X))/*+((float)(Math.PI)/2f)*/), position/2, scale,SpriteEffects.None,1);
        }
    }
}