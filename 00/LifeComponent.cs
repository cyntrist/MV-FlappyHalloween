// Decompiled with JetBrains decompiler
// Type: LifeComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class LifeComponent : MonoBehaviour
{
  [SerializeField]
  private GameObject _gameManager;

  private void OnCollisionEnter2D(Collision2D collision)
  {
    this._gameManager.SendMessage("OnPlayerDies");
    Object.Destroy((Object) this.gameObject);
  }
}
