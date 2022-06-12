using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEscalones : MonoBehaviour
{
    public GameObject Escalon;
    public Material Verde;
    public Material Rojo;
    GameObject GameManager;
   //public GameObject spawnN2;
   //public GameObject spawnN3;

    GameObject player;
    GameObject baseN2;
    GameObject escalonN2;
    public GameObject SigNivel;

    // GameObject ultPlataforma1;
  //  GameObject ultPlataforma2;

    bool tocado;
    float posZ;
    float posX;
    float posZ2;
    public int score;

    Lava ScriptLava;


    void Start()
    {
        posZ = Random.Range(-6.5f, 5.5f);
        posX = Random.Range(-81.5f, -69.5f);
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
                Instantiate(gameObject, new Vector3(transform.position.x - 8, transform.position.y, posZ), Quaternion.identity);
            }

            if (score == 7)
            {
                Vector3 posN2 = new Vector3(posX, 1.5f, 18.5f);
                Instantiate(SigNivel, posN2, Quaternion.identity);
            }

            Escalon.gameObject.GetComponent<Renderer>().material = Verde;
            StartCoroutine("cambiocolor");

        }

    }
}
