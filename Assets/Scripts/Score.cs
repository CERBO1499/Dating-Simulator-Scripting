﻿using System.Collections;
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
    


    public float _affection,addition, expectation;
    public float score, winScore, tempScore;

    private int tmpCount;
    [SerializeField] private int UmbralCount=5;
    [SerializeField] private int UmbralMaxCount=10;
    

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
                    tempScore = 0;

                    if (GameManager.Instance.Tg.Preffered==trate)
                    {
                        tempScore = addition * 0.2f;
                        score += addition + tempScore;

                    }
                    if (GameManager.Instance.Tg.Disliked==trate)
                    {
                        tempScore = addition * 0.45f;
                        
                        score += tempScore;

                    }


                    break;
                case EChicks.Basica:
                    tempScore = 0;

                    if (GameManager.Instance.Tg.Preffered==trate)
                    {
                        tempScore = addition * 0.4f;
                        score += addition + tempScore;

                    }
                    if (GameManager.Instance.Tg.Disliked==trate)
                    {
                        tempScore = addition * 0.45f;
                        
                        score += tempScore;

                    }
                    if (GameManager.Instance.Tg.Hated==trate)
                    {
                        float tmpInterest = GameManager.Instance.Tg.Interest;
                        tempScore = addition * 0.45f;
                        score += tempScore;
                        GameManager.Instance.Tg.RestInterest(tmpInterest*0.02f);

                    }

                   


                    break;
                case EChicks.Toxica:
                    tempScore = 0;

                    if (GameManager.Instance.Tg.Hated==trate)
                    {
                        tempScore = addition * 0.4f;

                    }

                    score += addition - tempScore;

                    break;
            }
            
            verifWinner();
        }

        if (trate == Etrait.Intimacy)
        {
            GameManager.Instance.Tg.Interest += 2;
        }

        if (trate == Etrait.Afecction)
        {
            tmpCount++;
            if (tmpCount >= UmbralCount && tmpCount<=UmbralMaxCount)
            {
                addition += addition * 0.05f;
            }
            
        }

        if (trate == Etrait.Boorish)
        {
            float tmpInterest = GameManager.Instance.Tg.Interest;
            addition -= addition * 0.75f;
            GameManager.Instance.Tg.RestInterest(tmpInterest*0.05f);
            
        }

       
        // _puntaje += adición;

    }

    void verifWinner()
    {
        if (GameManager.Instance.Tg.Expectation == score)
        {
            cambioEscena.Instance.Ganaste();
        }
    }
    void RestHate(Target target)
    {
        float a = (score * 0.2F);
        target.RestInterest(a);
    }
}