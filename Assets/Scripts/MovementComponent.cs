using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    #region parameters
    /// <summary>
    /// Force added to the player with each jump
    /// </summary>
    [SerializeField]
    private float _jumpForce;
    #endregion

    #region references
    /// <summary>
    /// Reference to own Rigid Body
    /// </summary>
    private Rigidbody2D _myRigidBody2D;
    #endregion

    #region methods
    /// <summary>
    /// Executes the jump of the player by:
    /// . Setting speed to zero
    /// . Adding the required force in vertical direction
    /// </summary>
    private void Jump()
    {
        _myRigidBody2D.velocity = Vector2.zero;
        _myRigidBody2D.AddForce(_jumpForce * Vector2.up, ForceMode2D.Impulse);
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _myRigidBody2D = GetComponent<Rigidbody2D>();
    }
}
