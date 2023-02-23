using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class heathbarscript : MonoBehaviour
{

    [SerializeField] private Image heathbarsprite;
    public TextMeshProUGUI TextLogAmount;
    


    void Start()
    {
        TextLogAmount = GameObject.Find("text").GetComponent<TextMeshProUGUI>();
    }

    public void helthbarUpdate(float maxhealth, float curhealth )
    {
        
        heathbarsprite.fillAmount = curhealth / maxhealth;
        TextLogAmount.text = curhealth.ToString();
        if (curhealth <= 0)
        {
            TextLogAmount.text = "0";
        }
    }
}
