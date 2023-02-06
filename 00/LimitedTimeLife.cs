// Decompiled with JetBrains decompiler
// Type: LimitedTimeLife
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class LimitedTimeLife : MonoBehaviour
{
  [SerializeField]
  private float _maxLifetime;

  private void SelfDestroy() => Object.Destroy((Object) this.gameObject);

  private void Start() => this.Invoke("SelfDestroy", this._maxLifetime);
}
