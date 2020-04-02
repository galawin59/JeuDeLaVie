using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridData 
{
    public int NbLine = 0;
    public int NbColumn = 0;
    public Case[,] Grid;
    public enum STATE { LIVE, DEAD };

    public class Case
    {
        public STATE state;
        public PosGrid PosGrid;

    };


    public struct PosGrid
    {
        public int column;
        public int line;
    };

    public GridData(int nbLine, int nbColumn)
    {
        NbColumn = nbColumn;
        NbLine = nbLine;
        Grid = new Case[nbColumn, nbLine];

        for (int i = 0; i < nbColumn; i++)
        {
            for (int j = 0; j < nbLine; j++)
            {
                Grid[i, j] = new Case();
                Grid[i, j].PosGrid.line = j;
                Grid[i, j].PosGrid.column = i;
                Grid[i, j].state = STATE.DEAD;
               

            }
        }
        Grid[5, 10].state = STATE.LIVE;
        Grid[6, 10].state = STATE.LIVE;
        Grid[7, 10].state = STATE.LIVE;
        Grid[8, 10].state = STATE.LIVE;
    }
}
