using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region references
    /// <summary>
    /// Reference to object containing GameOver text element
    /// </summary>
    [SerializeField]
    private GameObject _gameOverObject;
    #endregion

    #region methods
    /// <summary>
    /// Metrhod callled to activate the GameOver text element
    /// </summary>
    private void GameOver()
    {
        _gameOverObject.SetActive(true);
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        if (_gameOverObject != null)
        {
            Debug.Log("Canvas object found.");
            _gameOverObject.SetActive(false);
        }
    }
}
