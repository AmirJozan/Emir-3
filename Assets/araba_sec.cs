using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba_sec : MonoBehaviour
{
    public GameObject araba1;
    public GameObject araba2; 
    public GameObject araba3;
    public GameObject araba4;
    public GameObject araba5;
    public GameObject panel;
    public GameObject panel2;    
    

    // Start is called before the first frame update
    void Start()
    {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(true);
        panel2.SetActive(false);
                

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void araba1Button()     {
        araba1.SetActive(true);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(false);
        panel2.SetActive(true);
       
        
    }
    public void araba2Button()     {
        araba1.SetActive(false);
        araba2.SetActive(true);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(false);
        panel2.SetActive(true);
        
       
    }
    public void araba3Button()
    {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(true);
        araba4.SetActive(false);
        araba5.SetActive(false);
        panel.SetActive(false);
        panel2.SetActive(true);
        
        
    }
    public void araba4Button()
    {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(true);
        araba5.SetActive(false);
        panel.SetActive(false);
        panel2.SetActive(true);
        
        
    }
    public void araba5Button()
    {
        araba1.SetActive(false);
        araba2.SetActive(false);
        araba3.SetActive(false);
        araba4.SetActive(false);
        araba5.SetActive(true);
        panel.SetActive(false);
        panel2.SetActive(true);
        
        
    }
}
