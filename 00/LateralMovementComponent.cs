// Decompiled with JetBrains decompiler
// Type: LateralMovementComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class LateralMovementComponent : MonoBehaviour
{
  [SerializeField]
  private float _speed;
  private Transform _myTransform;
  private GameManager _gameManager;

  private void Start()
  {
    this._myTransform = this.transform;
    this._gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
  }

  private void Update()
  {
    if (!this._gameManager.IsGameRunning)
      return;
    this._myTransform.position -= this._speed * Time.deltaTime * Vector3.right;
  }
}
