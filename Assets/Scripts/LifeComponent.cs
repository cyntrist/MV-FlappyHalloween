using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeComponent : MonoBehaviour
{
    #region references
    /// <summary>
    /// Reference to Game Manager object
    /// </summary>
    [SerializeField]
    private GameObject _gameManager;
    #endregion

    #region methods
    /// <summary>
    /// Executed on collision. The component informs GameManger of its death before destroying itself.
    /// </summary>
    /// <param name="collision">Colliding element collision</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision.");
        _gameManager.SendMessage("OnPlayerDies");
        Destroy(this.gameObject);
    }
    #endregion
}
