using System;
using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{

    public static cambioEscena instance;

    public static cambioEscena Instance
    {
        get
        {
            if (instance == null)
            {
                instance=new cambioEscena();
            }

            return instance;
        }
    }

    public EChicks TipoChica
    {
        get => tipoChica;
        
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        instance = this;

        tipoChica = EChicks.Basica;
        //tipoChic = tipoChica;
        //a = 0;

        DontDestroyOnLoad(gameObject);
    }

    [SerializeField] public EChicks tipoChica;

    //[SerializeField] public int a;

    //public static EChicks tipoChica;

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SelecionChicas()
    {
        SceneManager.LoadScene("seleciondechicas");
    }
         
    public void GameOver()
    {
        SceneManager.LoadScene("GAME OVER");
    }
    public void Ganaste()
    {
        SceneManager.LoadScene("ganaste");
    }
       
    public void LaFresa()
    {
        Instance.Cambiar(EChicks.Fresa);
    }
    public void LaBasica()
    {
        Instance.Cambiar(EChicks.Basica);
    }
    public void LaToxica()
    {
        Instance.Cambiar(EChicks.Toxica);
    }

    public void Cambiar(EChicks chick)
    {
        tipoChica = chick;

        SceneManager.LoadScene("FinalScene3");
    }
}