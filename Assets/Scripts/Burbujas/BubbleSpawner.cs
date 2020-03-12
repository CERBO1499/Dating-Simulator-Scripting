using System;
using System.Collections;
using System.Collections.Generic;
using Bubbles;
using Enums;
using UnityEngine;
using Random = UnityEngine.Random;

public class BubbleSpawner : MonoBehaviour
{
    private PoolBubbles pool;
    private SpawnProbability probabilities;
   [SerializeField] private float speedBubbles;


    [SerializeField] private float timeBetwnspawns=2f;
    private float timer;

    [SerializeField] private float xValue;

    private int probability;

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
            probability = probabilities.EvaluateProbability();
            SpawnAtRandomPos(probability);
            timer = 0;
        }
    }

    void SpawnAtRandomPos(int index)
    {
        Etrait trait=Etrait.Boorish;
        
        GameObject refer = pool.Allocate(index);
        switch (probability)
        {
            case 0:
                trait = Etrait.Filrt;
                break;
            case 1:
                trait = Etrait.Love;
                break;
            case 2:
                trait = Etrait.Intelligence;
                break;
            case 3:
                trait = Etrait.Intimacy;
                break;
            case 4:
                trait = Etrait.Afecction;
                break;
            case 5:
                trait = Etrait.Boorish;
                break;
        }
        refer.GetComponent<Bubble>().Begin(trait,speedBubbles);
        
        refer.transform.position = transform.position + transform.right * Random.Range(-xValue, xValue);
        refer.SetActive(true);
    }
}
