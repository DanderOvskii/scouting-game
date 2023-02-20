using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heathbarscript : MonoBehaviour
{

    [SerializeField] private Image heathbarsprite;

    public void helthbarUpdate(float maxhealth, float curhealth )
    {
        heathbarsprite.fillAmount = curhealth / maxhealth;
    }
}
