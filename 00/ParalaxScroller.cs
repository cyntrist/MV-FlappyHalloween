// Decompiled with JetBrains decompiler
// Type: ParalaxScroller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ParalaxScroller : MonoBehaviour
{
  [SerializeField]
  private float _scrollSpeed;
  private SpriteRenderer _mySpriteRenderer;
  private Material _myMaterial;

  private void Stop() => this.enabled = false;

  private void Start()
  {
    this._mySpriteRenderer = this.GetComponent<SpriteRenderer>();
    this._myMaterial = this._mySpriteRenderer.material;
  }

  private void Update()
  {
    Vector2 mainTextureOffset = this._myMaterial.mainTextureOffset;
    this._myMaterial.mainTextureOffset = new Vector2(mainTextureOffset.x + 0.005f * this._scrollSpeed * Time.deltaTime, mainTextureOffset.y);
  }
}
