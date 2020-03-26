﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Clone
{
    public struct GameState
    {
        public Piece piece { get; set; }
        public Piece NextPiece { get; set; }

        public int gameTick { get; set; }
        public ShapeEnum[,] deadGrid { get; set; }
        public bool isTicking { get; set; }

        public bool isGameOver { get; set; }
        public bool softGameOver { get; set; }
        public bool isActive { get; set; }

        public int TotalLinesCleared { get; set; }

        public GameState(Game state)
        {
            this.piece = state.piece;
            this.NextPiece = state.NextPiece;
            this.gameTick = state.gameTick;
            this.deadGrid = state.deadGrid;
            this.isTicking = state.isTicking;
            this.isGameOver = state.isGameOver;
            this.softGameOver = state.softGameOver;
            this.isActive = state.isActive;
            this.TotalLinesCleared = state.TotalLinesCleared;

        }

    }
}
