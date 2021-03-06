﻿using System;

namespace WaterPipes.CommandsForGame
{
    internal class StartGame : ICommandForGame
    {
        private IsGameHasToStart gameState;

        public StartGame(IsGameHasToStart gameState)
        {
            this.gameState = gameState;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.Spacebar)
            {
                gameState.IsGameReady = true;
            }
        }
    }
}