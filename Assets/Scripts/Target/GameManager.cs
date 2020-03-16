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
                tg = chicks[0].GetComponent<Fresa>();
                Instantiate(chicks[0], targetPos.position, targetPos.rotation);
                break;

            case EChicks.Basica:
                tg = chicks[1].GetComponent<Basica>();

                Instantiate(chicks[1], targetPos.position, targetPos.rotation);
                break;

            case EChicks.Toxica:
                tg = chicks[2].GetComponent<Hater>();

                Instantiate(chicks[2], targetPos.position, targetPos.rotation);
                break;
        }
    }
}
