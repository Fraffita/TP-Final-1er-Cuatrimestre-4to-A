using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollsionEscalonN2 : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;
    GameObject GameManager;

    GameObject player;
    GameObject baseN2;
    public GameObject SigNivel;

    bool tocado;
    
    float posX;
    float posZ;
    
    public int score;

    Lava ScriptLava;


    void Start()
    {
        
        posX = Random.Range(-81.5f, -69.5f);
        posZ = Random.Range(88.6f, 75.5f);
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        ScriptLava = GameManager.GetComponent<Lava>();
        
        player = GameObject.FindGameObjectWithTag("Player");
        baseN2 = GameObject.FindGameObjectWithTag("baseN2");

    }

    IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(3f);
        Escalon.gameObject.GetComponent<Renderer>().material = Rojo;
        Destroy(Escalon, 1);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player" && tocado == false)
        {
            score += 1;
            Debug.Log(score);
            tocado = true;

            if (score < 7)
            {
                Instantiate(gameObject, new Vector3(posX, transform.position.y, transform.position.z + 8), Quaternion.identity);
                
            }

            if (score == 7)
            {
                Vector3 posN2 = new Vector3(-58, 1, posZ);
                Instantiate(SigNivel, posN2, Quaternion.identity);
            }

            Escalon.gameObject.GetComponent<Renderer>().material = Verde;
            StartCoroutine("cambiocolor");

            
        }

    }
}
