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

        private CollisionManager collisionManager;
        private RenderManager renderManager;

        public void Initialize(SpriteBatch batch, GraphicsDeviceManager device, ContentManager manager)
        {
            spriteBatch = batch;
            graphicsDevice = device;
            contentManager = manager;

            collisionManager = new CollisionManager();
            collisionManager.Initialize();
            renderManager = new RenderManager();
            renderManager.Initialize(spriteBatch, graphicsDevice);
        }

        public void Load()
        {

        }

        public void Update(GameTime gameTime)
        {
            collisionManager.Update(gameTime);
        }

        public void Draw()
        {
            renderManager.Draw();
        }
    }
}
