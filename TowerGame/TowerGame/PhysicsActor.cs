using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace TowerGame
{
    class PhysicsActor : ICollideable
    {
        public Vector2 Position { get; set; }
        public Rectangle Collider { get; set; }

        public void Initialize(Vector2 postion, Rectangle rectangle)
        {
            Position = postion;
            Collider = rectangle;
        }
    }
}
