using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestController : MonoBehaviour
{
    GameSceneDirector sceneDirector;

    // 初期化
    public void Init(GameSceneDirector sceneDirector)
    {
        this.sceneDirector = sceneDirector;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // プレイヤーじゃない
        if (!collision.gameObject.TryGetComponent<PlayerController>(out var player)) return;

        sceneDirector.DispPanelTreasureChest();
        Destroy(gameObject);
    }
}

