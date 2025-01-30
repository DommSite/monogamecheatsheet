using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogamecheatsheet
{
    public class Bullet : BaseClass
    {
        private int size;
        private Color color;
        
        Vector2 direction;
        //float angle;
        Vector2 position;







        public Bullet(Texture2D texture, Vector2 position, float angle)
            :base(texture, new Microsoft.Xna.Framework.Vector2(position.X, position.Y))
        {
            color = Microsoft.Xna.Framework.Color.Green;
        }
    }
}