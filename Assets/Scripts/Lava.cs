using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    AudioSource source;
    public GameObject PlayerSpawnPosition;
    private bool Isdead = false;

    public int caidasN1;

    public GameObject Escalones;
    public float RangoCreacion = 14f;

    float posZ;
    private void Start()
    {
        caidasN1 = 0;
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Isdead = true;
            caidasN1 ++;

            if (Isdead){

                source.Play();

            }
            collision.gameObject.transform.position = PlayerSpawnPosition.transform.position;

            Isdead = false;

           GameObject[] escalones = GameObject.FindGameObjectsWithTag("escalon");
            foreach (GameObject escalon in escalones)
            {

             GameObject.Destroy(escalon);

            }

            posZ = Random.Range(-6.5f, 5.5f);
            Vector3 SpawnPosition = new Vector3(-9.7f, 1.7f, posZ);
             GameObject Escalon = Instantiate(Escalones, SpawnPosition, Quaternion.identity);
        }
    }
}
