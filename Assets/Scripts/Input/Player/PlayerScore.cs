using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Bubbles;

public class PlayerScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI puntaje;
    [SerializeField]
    private TextMeshProUGUI puntajeGanar;
    [SerializeField]
    private TextMeshProUGUI affection;
    [SerializeField]
    private TextMeshProUGUI interest;


    public int _puntaje;
    public int _puntajeGanar;
    public int _affection;
    public int adición;

    // Start is called before the first frame update
    private void Awake()
    {
        Bubble.InBubblePop += SumarPuntaje;
    }

    void Start()
    {
        _puntaje = 0;
        _puntajeGanar = 10;
        _affection = 0;
        adición = 2;
        
    }

    void Update()
    {
        puntaje.text = "Puntaje: " + _puntaje.ToString();
        puntajeGanar.text = "Para Ganar: " + _puntajeGanar.ToString();
        affection.text = "Affection: " + _affection.ToString();
    }

    void SumarPuntaje()
    {      
        _puntaje += adición;
    }
}
