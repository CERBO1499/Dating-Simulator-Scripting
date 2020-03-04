using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BubbleSpawner : MonoBehaviour
{
    private PoolBubbles pool;
    private SpawnProbability probabilities;


    [SerializeField] private float timeBetwnspawns=2f;
    private float timer;

    [SerializeField] private float xValue;

    private void Awake()
    {
        pool = GetComponent<PoolBubbles>();
        probabilities = GetComponent<SpawnProbability>();
    }


    
        
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetwnspawns)
        {
            SpawnAtRandomPos(probabilities.EvaluateProbability());
            timer = 0;
        }
    }

    void SpawnAtRandomPos(int index)
    {
        GameObject refer = pool.Allocate(index);
        refer.transform.position = transform.position + transform.right * Random.Range(-xValue, xValue);
        refer.SetActive(true);
    }
}
