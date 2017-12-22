using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    interface IEntity
    {
        Vector2 Position { get; set; }
        void Initialize();
        void Load();
        void Update();
    }
}
