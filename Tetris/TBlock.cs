using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class TBlock : Block
    {
        public override int Id => 6;

        protected override Position[][] Tiles => tiles;

        protected override Position StartOffSet => new Position(0,3);

        private readonly Position[][] tiles= new Position[][]
        {
            new Position[]{new(0,1), new(1,0), new(1,1),new(1,2)},
            new Position[]{new(0,1), new(1,1), new(1,2),new(2,1)},
            new Position[]{new(1,0), new(1,1), new(1,2),new(1,1)},
            new Position[]{new(0,1), new(1,0), new(1,1),new(2,1)},
        };
    }
}
