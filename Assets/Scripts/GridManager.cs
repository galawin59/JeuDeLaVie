using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    private static GridManager instance = null;
    public static GridManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<GridManager>();
            return instance;
        }
        
    }
    private void Awake()
    {
     
        rootTree = new GridData(NbLines, NbColumns);
       
    }
    public int NbLines = 0;
    public int NbColumns = 0;
    GridData rootTree;


    public GridData.Case GetCase(int column, int line)
    {
       
            return rootTree.Grid[column, line];
       
    }
    public GridData.STATE GetCaseState(int column, int line)
    {
      
            return rootTree.Grid[column, line].state;
      
    }
}
