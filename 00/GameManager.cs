// Decompiled with JetBrains decompiler
// Type: GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42F0BB62-78DE-4CB2-841A-E887B3134CBD
// Assembly location: E:\Programas\OneDrive - Universidad Complutense de Madrid (UCM)\UCM\S1\motores\p1\Mot2022_P1_Build\Mot2022_P1_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class GameManager : MonoBehaviour
{
  [SerializeField]
  private GameObject _player;
  [SerializeField]
  private GameObject _UIManager;
  [SerializeField]
  private GameObject _levelManager;
  private bool _isGameRunning;

  public bool IsGameRunning => this._isGameRunning;

  private void Jump() => this._player.SendMessage(nameof (Jump));

  private void OnPlayerDies()
  {
    this._UIManager.SendMessage("GameOver");
    this._levelManager.SendMessage("GameOver");
    this.SendMessage("Stop");
    this._isGameRunning = false;
  }

  private void Start() => this._isGameRunning = true;
}
