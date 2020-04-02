using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    GridManager im;



    [SerializeField] GameObject prebabsCases = null;
    [SerializeField] GameObject prebabsCasesIsLife = null;
    [SerializeField] float sizeCase = 1f;
    bool isAlive = false;


    void Start()
    {
        im = GridManager.Instance;
        for (int i = 0; i < im.NbColumns; i++)
        {
            for (int j = 0; j < im.NbLines; j++)
            {

                if (im.GetCaseState(i, j) == GridData.STATE.LIVE)
                {
                    Instantiate(prebabsCasesIsLife, new Vector2(i, j) * sizeCase, Quaternion.identity);
                }
                else
                {
                    Instantiate(prebabsCases, new Vector2(i, j) * sizeCase, Quaternion.identity);
                }
            }
        }
    }


    void Update()
    {

    }
}
