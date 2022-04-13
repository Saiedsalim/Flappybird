using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipesPrefab;

    float randomHeight = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 3.00f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPipes()
    {

        Instantiate(pipesPrefab, new Vector2(2, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }
}