﻿using System;

namespace WaterPipes.CommandsForGame
{
    internal class MoveCursorRight : ICommandForGame
    {
        private Cursor cursorForChanges;

        public MoveCursorRight(Cursor inputedCursor)
        {
            cursorForChanges = inputedCursor;
        }

        public void PerformCommand(ConsoleKey inputedKey)
        {
            if (inputedKey == ConsoleKey.RightArrow)
            {
                cursorForChanges.XCordinate += 1;
            }
        }
    }
}