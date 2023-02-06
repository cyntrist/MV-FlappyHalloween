// Decompiled with JetBrains decompiler
// Type: MovementComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class MovementComponent : MonoBehaviour
{
  [SerializeField]
  private float _jumpForce;
  private Rigidbody2D _myRigidBody2D;

  private void Jump()
  {
    this._myRigidBody2D.velocity = Vector2.zero;
    this._myRigidBody2D.AddForce(new Vector2(0.0f, this._jumpForce));
  }

  private void Start() => this._myRigidBody2D = this.GetComponent<Rigidbody2D>();
}
