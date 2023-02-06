using UnityEngine;

public class LimitedTimeLife : MonoBehaviour
{
    #region paramaters
    /// <summary>
    /// Maximum time before the script destroys the object
    /// </summary>
    [SerializeField]
    private float _maxLifetime;
    #endregion

    #region methods
    /// <summary>
    /// Destroys the associated game object
    /// </summary>
    private void SelfDestroy()
    {
        Destroy(gameObject, _maxLifetime);
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        SelfDestroy();
    }
}
