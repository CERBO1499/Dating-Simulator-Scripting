using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Enums;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EChicks chick;
    [SerializeField] private Transform targetPos;
    [SerializeField] private GameObject[] chicks;
    public static GameManager instance;
    private Target tg;

    public Target Tg
    {
        get => tg;
    }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance=new GameManager();
            }

            return instance;
        }
    }

    private void Awake()
    {
      if(instance!=null){Destroy(instance);}

      instance = this;
      
      
        chick = cambioEscena.Instance.TipoChica;
        SpawnTarget();
    }

    private void SpawnTarget()
    {
        switch (chick)
        {
            case EChicks.Fresa:
                //tg = chicks[0].GetComponent<Fresa>();
                tg=(Instantiate(chicks[0], targetPos.position, targetPos.rotation)).GetComponent<Fresa>();
                tg.Begin(100,50);
                
                break;

            case EChicks.Basica:
                tg=(Instantiate(chicks[1], targetPos.position, targetPos.rotation)).GetComponent<Basica>();
                tg.Begin(50,50);
                break;

            case EChicks.Toxica:
                tg=(Instantiate(chicks[2], targetPos.position, targetPos.rotation)).GetComponent<Hater>();
                tg.Begin(50,20);
                break;
        }
    }
}
