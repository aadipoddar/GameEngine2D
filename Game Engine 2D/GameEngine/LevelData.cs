﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GameEngine
{
    public class LevelData
    {
        [XmlElement("Player", Type = typeof(Player))]
        [XmlElement("Enemy", Type = typeof(Enemy))]
        [XmlElement("PowerUp", Type = typeof(PowerUp))]
        public List<GameObject> objects { get; set; }

        public List<Wall> walls { get; set; }

        public List<Decor> decor { get; set; }

        public int mapWidth { get; set; }
        public int mapHeight{ get; set; }
    }
}
