using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator Wait()
    {
        while(true)
        {
         yield return new WaitForSeconds(1.0f);

           

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    // passe vivante
    bool isExactThreeNeigtbourLife()
    {
       
        for (int i = 0; i < GridManager.Instance.NbColumns; i++)
        {
            for (int j = 0; j < GridManager.Instance.NbLines; j++)
            {
                if(GridManager.Instance.GetCaseState(i,j) == GridData.STATE.LIVE)
                {
                    int counterLife = 0;
                    for (int k = -1; k < 2; k++)
                    {
                        for (int l = -1; l < 2; l++)
                        {
                            if(k != 0  && l != 0)
                            {
                                if (GridManager.Instance.GetCaseState(k, l) == GridData.STATE.LIVE)
                                {
                                    counterLife++;
                                }
                            }
                            
                        }
                    }
                    if (counterLife == 3)
                    {
                        // a finir
                    }
                }
            }
        }
        return true;
    }

    //meme etat
    bool isExactTwoNeigtbourLife()
    {
        return true;
    }

    //passe morte
    bool isMoreThreeNeigtbourLifeOrLessTwo()
    {
        return true;
    }
}
