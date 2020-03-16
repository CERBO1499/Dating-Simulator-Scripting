using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Bubbles;
using Enums;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI puntaje;
    [SerializeField]
    private TextMeshProUGUI puntajeGanar;
    [SerializeField]
    private TextMeshProUGUI affection;
    


    public int _affection,addition, expectation;
    public float score, winScore;

    // Start is called before the first frame update
    private void Awake()
    {
        Bubble.InBubblePop += AddScore;
    }

    void Start()
    {
        score = 0;
        winScore = 10;
        _affection = 0;
        addition = 2;

        
    }
    void Update()
    {
        winScore = expectation - score;
        if (winScore <= 0)
        {
            winScore = 0;
        }
        puntaje.text = "Puntaje: " + score.ToString();
        puntajeGanar.text = "Para Ganar: " + winScore.ToString();
        affection.text = "Affection: " + _affection.ToString();
    }

    
    void AddScore(Etrait trate)
    {
        EChicks girl=cambioEscena.Instance.TipoChica;
        if (trate == Etrait.Love || trate == Etrait.Filrt || trate == Etrait.Intelligence)
        {
            switch (girl)
            {
                case EChicks.Fresa:
                    score *= (1 + 0.2F);    
                    break;
                case EChicks.Basica:
                    score *= (1 - 0.4F);
                    break;
                case EChicks.Toxica:
                    score *= (1 - 0.4F);                   
                    break;
            }
        }
     
        // _puntaje += adición;

    }
    void RestHate(Target target)
    {
        float a = (score * 0.2F);
        target.RestInterest(a);
    }
}