using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangSpawnerController : BaseWeaponSpawner
{
    // Update is called once per frame
    void Update()
    {
        if (isSpawnTimerNotElapsed()) return;

        // 武器生成
        for (int i = 0; i < Stats.SpawnCount; i++)
        {
            createWeapon(transform.position);
        }

        spawnTimer = Stats.GetRandomSpawnTimer();
    }
}
