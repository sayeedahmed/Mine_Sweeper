using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine_Sweeper
{
    public class Block
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public bool isLandmine { get; set; }
        public int value { get; set; }
        public bool isClicked { get; set; }
        public bool isFlagged { get; set; }

        public Block(int posX, int posY, bool isLandmine, int value = 0, bool isClicked = false, bool isFlagged = false)
        {
            this.posX = posX;
            this.posY = posY;
            this.isLandmine = isLandmine;
            this.value = value;
            this.isClicked = isClicked;
            this.isFlagged = isFlagged;
        }
    }
}
