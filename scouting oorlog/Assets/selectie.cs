using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectie : MonoBehaviour
{

    public GameObject koen1;
    public GameObject koen2;
    public GameObject dax1;
    public GameObject dax2;

    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        koen1.SetActive(false);
        koen2.SetActive(false);
        dax1.SetActive(false);
        dax2.SetActive(false);

        menu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Koen1()
    {
        koen1.SetActive(true);
       
        dax1.SetActive(false);
       

    }
    public void Dax1()
    {
        koen1.SetActive(false);
        
        dax1.SetActive(true);
       

    }
    public void Koen2()
    {
        
        koen2.SetActive(true);
       
        dax2.SetActive(false);

    }
    public void Dax2()
    {
       
        koen2.SetActive(false);
      
        dax2.SetActive(true);

    }

    public void fight()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }


}
