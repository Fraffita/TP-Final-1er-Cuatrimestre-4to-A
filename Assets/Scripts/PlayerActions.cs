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

    void Start()
    {
        PanelFinal.SetActive(false);
    }

    void Update()
    {
        
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
