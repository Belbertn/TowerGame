using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace TowerGame
{
    class CollisionManager
    {
        private static List<ICollideable> collideableEntities;

        public void Initialize()
        {
            collideableEntities = new List<ICollideable>();

        }

        public void Update(GameTime gameTime)
        {

        }

        public static void AddCollideableEntity(ICollideable entity)
        {
            collideableEntities.Add(entity); 
        }
    }
}
