using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EChicks chick;
    [SerializeField] private Transform targetPos;
    [SerializeField] private GameObject[] chicks;

    private void Awake()
    {
      
        chick = cambioEscena.Instance.TipoChica;
        SpawnTarget();
    }

    private void SpawnTarget()
    {
        switch (chick)
        {
            case EChicks.Fresa:
                Instantiate(chicks[0], targetPos.position, targetPos.rotation);
                break;

            case EChicks.Basica:
                Instantiate(chicks[1], targetPos.position, targetPos.rotation);
                break;

            case EChicks.Toxica:
                Instantiate(chicks[2], targetPos.position, targetPos.rotation);
                break;
        }
    }
}
