// Decompiled with JetBrains decompiler
// Type: ObstaclesGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
  [SerializeField]
  private GameObject[] _prefabs;
  [SerializeField]
  private Transform _spawnTransform;
  [SerializeField]
  private float _maxTimeInterval = 5f;
  [SerializeField]
  private float _minTimeInterval = 1f;
  private float _elapsedTime;
  private float _nextSpawnTime;

  private void Stop() => this.enabled = false;

  private void Update()
  {
    this._elapsedTime += Time.deltaTime;
    if ((double) this._elapsedTime < (double) this._nextSpawnTime)
      return;
    this._elapsedTime = 0.0f;
    this._nextSpawnTime = Random.Range(this._minTimeInterval, this._maxTimeInterval);
    Object.Instantiate<GameObject>(this._prefabs[Random.Range(0, this._prefabs.Length)], this._spawnTransform.position, Quaternion.identity);
  }
}
