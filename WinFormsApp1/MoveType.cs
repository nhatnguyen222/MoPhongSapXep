using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public enum MoveType
    {
        MOVE_TOP_DOWN,
        MOVE_LEFT_RiGHT,
        MOVE_IN_LINE,
        MOVED
    }
    public class Status
    {
        public MoveType type { get; set; }
        public int Pos1 { get; set; }
        public int Pos2 { get; set; }

    }
}
