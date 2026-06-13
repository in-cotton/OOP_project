using System;
using System.Collections.Generic;
using OOP_project.Source.Models;

namespace OOP_project.Source.Logic
{
    public delegate void ShowHighlightHandler(List<Cell> cells);

    public class AvailableApple
    {
        private List<Cell> availableApple;
        private int availableSum;

        public event ShowHighlightHandler OnShowHighlight;

        public AvailableApple(List<Cell> cells)
        {
            availableApple = cells;
            availableSum = 0;

            foreach (Cell cell in cells)
            {
                if (cell.HasApple())
                {
                    availableSum += cell.apple.GetValue();
                }
            }
        }

        public bool IsValid()
        {
            return availableSum == 10;
        }

        public void Show()
        {
            OnShowHighlight?.Invoke(availableApple);
        }

        public List<Cell> GetCells()
        {
            return availableApple;
        }

        public int GetSum()
        {
            return availableSum;
        }
    }
}