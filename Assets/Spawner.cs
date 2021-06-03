using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject SpawnPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 0.1f);
    }

    void Spawn()
    {
        Instantiate(SpawnPrefab, transform.position, Quaternion.identity);
    }
}
