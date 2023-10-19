using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerate : MonoBehaviour
{
    public GameObject LevelWallsPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 SpawnerPosition = new Vector3();

        while (true)
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnerPosition.y += Random.Range(2f, 4f);

            Instantiate(LevelWallsPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

}
