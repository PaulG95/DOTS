using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    [SerializeField] private float spawnTimer;

    public float GetSpawnTimer()
    {
        return spawnTimer;
    }
}
