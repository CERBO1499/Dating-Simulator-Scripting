using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIMan : MonoBehaviour
{
    //  SINGLETON
    public static UIMan instance;

    public static UIMan Instance
    {
        get
        {
            if (instance == null) instance = new UIMan();
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null) Destroy(instance);
        instance = this;

        Inicializar();
    }
    //  SINGLETON

    [SerializeField] TextMeshProUGUI interestTxt;

    [SerializeField] RawImage loseImg;

    public void Inicializar()
    {
        LoseOn(false);
    }

    public void ShowInterest(float inter)
    {
        interestTxt.text = ("INTEREST: " + inter.ToString());
    }

    public void LoseOn(bool state)
    {
        loseImg.gameObject.SetActive(state);
    }
}
