using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TowerGame
{
    class RenderManager
    {
        private static List<IDrawable> drawableEntities;

        private SpriteBatch spriteBatch;
        private GraphicsDeviceManager graphicsDevice;

        public void Initialize(SpriteBatch batch, GraphicsDeviceManager manager)
        {
            drawableEntities = new List<IDrawable>();

            spriteBatch = batch;
            graphicsDevice = manager;
        }

        public void Draw()
        {
            spriteBatch.Begin();

            foreach (IDrawable entity in drawableEntities)
            {
                spriteBatch.Draw(entity.Sprite, entity.Position, Color.White);
            }

            spriteBatch.End();
        }

        public static void AddDrawableEntity(IDrawable entity)
        {
            drawableEntities.Add(entity);
        }
    }
}
