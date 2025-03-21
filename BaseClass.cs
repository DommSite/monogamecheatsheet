using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogamecheatsheet
{
    public class BaseClass{
        protected Vector2   position;
        protected Texture2D texture;
        protected Color     color;
        protected Rectangle rectangle;

        public Rectangle Rectangle{
            get{return rectangle;}
        }

        public BaseClass(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
            color = Color.White;
        }

        public virtual void Update(){
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            rectangle = new Rectangle((int)(position.X - 50), (int)(position.Y - 50) ,30, 30);

            spriteBatch.Draw(texture, rectangle, color);
        }
    }       
}