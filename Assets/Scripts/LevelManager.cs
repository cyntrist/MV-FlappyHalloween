using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region methods
    /// <summary>
    /// Stops the paralax scrollers
    /// </summary>
    /// 
    private void GameOver()
    {
        foreach (ParalaxScroller ps in GetComponentsInChildren<ParalaxScroller>())
        {   
            ps.Stop() ;
        }
    }
    #endregion
}
