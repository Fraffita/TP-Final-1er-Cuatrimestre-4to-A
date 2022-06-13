using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    public GameObject baseFinal;
    public GameObject PanelFinal;
    public Text Tiempo;
    bool tocado;
    float timer;
    float StartTime;


    void Start()
    {
        PanelFinal.SetActive(false);
        StartTime = 0;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartTime = StartTime + 1;

            if (StartTime == 1)
            {
                Tiempo.text = timer.ToString();
                timer = Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "baseFinal" && tocado == false)
        {
            PanelFinal.SetActive(true);
            tocado = true;

        }
    }

   



}
