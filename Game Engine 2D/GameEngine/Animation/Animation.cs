using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GameEngine
{
    public class Animation //Individual animation , many of these usually makeup an AnimationSet
    {
        public string name;
        public List<int> animationOrder = new List<int>();
        public int speed;

        public Animation()
        {

        }

        public Animation(string inputName, int inpuSpeed, List<int> inputAnimationOrder)
        {
            name = inputName;
            speed = inpuSpeed;
            animationOrder = inputAnimationOrder;
        }
    }

    public class AnimationSet
    {
        public int width;//width of each frame
        public int height; // height of each frame 
        public int gridX; //how many frames are in the x direction
        public int gridY;//how many frames are in the y direction
        public List<Animation> animationList = new List<Animation>();

        public AnimationSet()
        {
        }
        
        public AnimationSet(int inputWidth, int inputHeight, int inputGridX, int inputGridY)
        {
            width = inputWidth;
            height = inputHeight;
            gridX = inputGridX;
            gridY = inputGridY;
        }
    }

    public class AnimationData
    {
        public AnimationSet animation { get; set; }
        public string texturePath { get; set; }
    }
}
