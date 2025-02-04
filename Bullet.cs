using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogamecheatsheet
{
    public class Bullet : BaseClass
    {
        private int size;
        Texture2D bulletImage;
        
        double angle;
        Vector2 position;







        public Bullet(Texture2D texture, Vector2 position, double angle)
            :base(texture, new Microsoft.Xna.Framework.Vector2(position.X, position.Y))
        {
            this.bulletImage = texture;
            this.angle = angle;
            this.position = position;
        }

        public override void Update(){
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }



    }
}