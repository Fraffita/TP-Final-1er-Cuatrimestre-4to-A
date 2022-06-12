using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava1 : MonoBehaviour
{

    AudioSource source;
    public GameObject PlayerSpawnPosition;
    private bool Isdead = false;
    public GameObject Escalones;
    public float RangoCreacion = 14f;
    float posX;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Isdead = true;
            if (Isdead)
            {

                source.Play();

            }
            collision.gameObject.transform.position = PlayerSpawnPosition.transform.position;

            Isdead = false;

            GameObject[] escalones = GameObject.FindGameObjectsWithTag("escalon");
            foreach (GameObject escalon in escalones)
            {

                GameObject.Destroy(escalon);

            }

            posX = Random.Range(-81.5f, -69.5f);
            Vector3 SpawnPosition = new Vector3(posX, 1.5f, 18.5f);
            GameObject Escalon = Instantiate(Escalones, SpawnPosition, Quaternion.identity);
        }
    }
}
