using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolBubbles : MonoBehaviour
{
    [SerializeField] private GameObject[] References;
    private List<GameObject>[] poolStock;
   
    
    [SerializeField] private int starSize;

    private void Awake()
    {
        Spawn();
    }

    void Spawn()
    {
        if(References==null || References.Length<=0)
        {
            return;
        }
        poolStock=new List<GameObject>[References.Length];
        if (starSize<References.Length)
        {
            starSize = References.Length;
        }
        for (int i = 0; i < References.Length; i++)
        {
            poolStock[i]=new List<GameObject>();
            for (int j = 0; j < starSize/References.Length; j++)
            {
                poolStock[i].Add(Instantiate(References[i],new Vector3(1000,1000,100 ),Quaternion.identity,null));
                poolStock[i].Last().SetActive(false);
            }
        }
    }
    /// <summary>
    /// Fetches a gameObject that is available in the stock, if fails it will return a new object
    /// </summary>
    /// <param name="index">Which type will you like to spawn </param>
    /// <returns>First gameObject</returns>
    public GameObject Allocate(int index)
    {
        if (index > References.Length - 1)
        {
            index = References.Length - 1;
        }
        foreach (var obj in poolStock[index])
        {
            if (!obj.activeSelf)
            {
                return obj;
            }
        }

        GameObject newObj = Instantiate(References[index], new Vector3(1000, 1000, 100), Quaternion.identity, null);
        poolStock[index].Add(newObj);
        newObj.SetActive(false);
        return newObj;
    }
    
}
