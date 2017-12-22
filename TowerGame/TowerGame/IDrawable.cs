using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    interface IDrawable
    {
        Vector2 Position { get; set; }
        Texture2D Sprite { get; set; }
    }
}
