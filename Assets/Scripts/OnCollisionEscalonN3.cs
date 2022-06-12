using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalonN3 : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;
    GameObject GameManager;
    //public GameObject spawnN2;
    //public GameObject spawnN3;

    GameObject player;
    GameObject baseN2;
    public GameObject SigNivel;

    // GameObject ultPlataforma1;
    //  GameObject ultPlataforma2;

    bool tocado;

    float posZ;

    public int score;

    Lava ScriptLava;


    void Start()
    {

        posZ = Random.Range(88.6f, 75.5f);
        GameManager = GameObject.FindGameObjectWithTag("GameController");
        ScriptLava = GameManager.GetComponent<Lava>();

        player = GameObject.FindGameObjectWithTag("Player");
        baseN2 = GameObject.FindGameObjectWithTag("baseN2");

    }

    IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(2f);
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
                Instantiate(gameObject, new Vector3(transform.position.x +8 , transform.position.y + 1, posZ), Quaternion.identity);

            }

            /*if (score == 7)
            {
                Vector3 posN3 = new Vector3(0, 0, 0);
                Instantiate(SigNivel, posN3, Quaternion.identity);
                Destroy(SigNivel);
            }*/

            Escalon.gameObject.GetComponent<Renderer>().material = Verde;
            StartCoroutine("cambiocolor");


        }

    }
}
