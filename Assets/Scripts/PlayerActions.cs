using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{

    //Rango de creación de pérdidas
    float posX;
    float posZ;

    //Bases de niveles
    public GameObject baseN2;
    public GameObject baseN3;
    public GameObject baseFinal;

    public GameObject PanelFinal;
    public GameObject PanelInicio;
    public GameObject pelotita;

    //Pisos
    public GameObject Lava;
    public GameObject Lava1;
    public GameObject Lava2;




    public Text Tiempo;
    public Text veces_caidas;

    Lava ScriptLava;
    Lava1 ScriptLava1;
    Lava2 ScriptLava2;

    bool tocado;
    float timer;
    float StartTime;
    float TimerStart;
    public int caidas_T;

    void Start()
    {
        posX = Random.Range(23, 29.71f);
        posZ = Random.Range(87.71f, 76.8f);
        PanelFinal.SetActive(false);
        PanelInicio.SetActive(true);
        StartTime = 0;

        caidas_T = 0;

        ScriptLava = GameObject.FindGameObjectWithTag("Lava").GetComponent<Lava>();
        ScriptLava1 = GameObject.FindGameObjectWithTag("Lava1").GetComponent<Lava1>();
        ScriptLava2 = GameObject.FindGameObjectWithTag("Lava2").GetComponent<Lava2>();

        

        TimerStart = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartTime = StartTime + 1;
            if (StartTime == 1)
            {
                TimerStart = Mathf.FloorToInt(Time.time);
                PanelInicio.SetActive(false);
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "baseFinal" && tocado == false)
        {
            caidas_T = (ScriptLava.caidasN1 + ScriptLava1.caidasN2 + ScriptLava2.caidasN3) /4;
            PanelFinal.SetActive(true);
            tocado = true;
            int tiempofinal = Mathf.FloorToInt(Time.time);
            Tiempo.text = "Tardaste "+ (tiempofinal - TimerStart).ToString()+" segundos";
            veces_caidas.text = "Perdiste " + caidas_T + " veces.";

           
            for (int i = 0; i < caidas_T; i++)
            {
                Instantiate(pelotita, new Vector3(posX, 11.99f, posZ), Quaternion.identity);

            }
        }




    }

   



}
