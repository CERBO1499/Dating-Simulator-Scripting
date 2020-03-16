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
        
        DontDestroyOnLoad(gameObject);
    }

    [SerializeField]private EChicks tipoChica;
    
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
        tipoChica = EChicks.Fresa;

        SceneManager.LoadScene("FinalScene3");
    }
    public void LaBasica()
    {
        tipoChica = EChicks.Basica;
        SceneManager.LoadScene("FinalScene3");
    }
    public void LaToxica()
    {
        tipoChica = EChicks.Toxica;
        SceneManager.LoadScene("FinalScene3");
    }
}