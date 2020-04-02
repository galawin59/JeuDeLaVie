using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    static GridManager instance = null;
    public static GridManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
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
