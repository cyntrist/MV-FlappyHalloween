using UnityEngine;

public class LateralMovementComponent : MonoBehaviour
{
    #region parameters
    /// <summary>
    /// Movement speed for the obstacle
    /// </summary>
    [SerializeField]
    private float _speed;
    #endregion

    #region references
    /// <summary>
    /// Reference to own transform
    /// </summary>
    private Transform _myTransform;
    /// <summary>
    /// Reference to Game Manager 
    /// </summary>
    private GameManager _gameManager;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _myTransform = transform;
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameManager != null && _gameManager.IsGameRunning)
        {
            _myTransform.position += _speed * Time.deltaTime * Vector3.left;
        }
    }
}
