using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogamecheatsheet
{
    public class BulletSystem
    {
        List<Bullet> bullets = new List<Bullet>();
        Texture2D bulletImage;
        
        public BulletSystem(Texture2D bulletImage){
            this.bulletImage = bulletImage;
        }

        public void SummonBullet(Vector2 position, double angle){
            bullets.Add(new Bullet(bulletImage, position, angle));
        }

        public virtual void Update(){
            foreach(var Bullet in bullets){
                Bullet.Update();
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            
        }
    }
}