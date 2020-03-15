using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{

    
    public void Menu()
    {

        SceneManager.LoadScene("Menu");
    }

    public void SelecionChicas()
    {
        SceneManager.LoadScene("seleciondechicas");
    }
         
    public void Jugar()
    {
        SceneManager.LoadScene("FinalScene");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GAME OVER");
    }
    public void Ganaste()
    {
        SceneManager.LoadScene("ganaste");
    }
        
    
}