using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogamecheatsheet
{
    public class BulletSystem
    {
        List<Bullet> bullets = new List<Bullet>();
        Texture2D texture;
        public BulletSystem(Texture2D texture){
            this.texture = texture;
        }

        public void SummonBullet(Vector2 position, float angle){
            bullets.Add(new Bullet());
        }

        public void Update(){

        }
    }
}