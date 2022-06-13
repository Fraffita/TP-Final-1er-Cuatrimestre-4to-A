using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    //Estructuras de bloqueo
    public GameObject BloqueoN1;
    public GameObject BloqueoN2;
    public GameObject BloqueoN3;


    //Bases de niveles
    public GameObject baseN2;
    public GameObject baseN3;

    public GameObject baseFinal;
    public GameObject PanelFinal;
    public Text Tiempo;

    bool tocado;
    float timer;
    float StartTime;
    float TimerStart;


    void Start()
    {
        PanelFinal.SetActive(false);
        StartTime = 0;

        TimerStart = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartTime = StartTime + 1;
            if (StartTime == 1)
            {
                TimerStart = Time.time;
                PanelFinal.SetActive(false);
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "baseFinal" && tocado == false)
        {
            PanelFinal.SetActive(true);
            tocado = true;
            Tiempo.text = "Tardaste "+(Mathf.FloorToInt(Time.time) - TimerStart).ToString()+" segundos";
        }

        //if (collision.gameObject.tag == "baseN2" && tocado == false)
        //{
        //    tocado = true;
        //}
    }

   



}
