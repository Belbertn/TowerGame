using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TowerGame
{
    class MainGame
    {
        private SpriteBatch spriteBatch;
        private GraphicsDeviceManager graphicsDevice;
        private ContentManager contentManager;

        public void Initialize(SpriteBatch batch, GraphicsDeviceManager device, ContentManager manager)
        {
            spriteBatch = batch;
            graphicsDevice = device;
            contentManager = manager;
        }

        public void Load()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw()
        {
            spriteBatch.Begin();

            spriteBatch.End();
        }
    }
}
