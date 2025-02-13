using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogamecheatsheet
{
    public class Bullet : BaseClass
    {
        private int size;
        Texture2D bulletImage;
        private float speed = 1;
        
        private Vector2 direction;
        







        public Bullet(Texture2D texture, Vector2 position, Vector2 direction)
            :base(texture, new Microsoft.Xna.Framework.Vector2(position.X, position.Y))
        {
            this.bulletImage = texture;
            this.direction = direction;
            this.position = position;
        }

        public override void Update(){
            position += direction * speed;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, bulletImage.Width, bulletImage.Height);
            Vector2   scale;
            scale.X = 0.01f;
            scale.Y = 0.01f;

            spriteBatch.Draw(bulletImage, position, sourceRectangle,Color.White, (float)(Math.Atan2(direction.Y,direction.X)), position, scale,SpriteEffects.None,1);
        }



    }
}