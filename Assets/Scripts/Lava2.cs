using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava2 : MonoBehaviour
{
    AudioSource source;
    public GameObject PlayerSpawnPosition;
    private bool Isdead = false;
    public GameObject Escalones;
    public float RangoCreacion = 14f;

    public int caidasN3;
    float posZ;
    void Start()
    {
        caidasN3 = 0;
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Isdead = true;
            caidasN3 = caidasN3 + 1;
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

            posZ = Random.Range(88.6f, 75.5f);
            Vector3 SpawnPosition = new Vector3(-58, 1.5f, posZ);
            GameObject Escalon = Instantiate(Escalones, SpawnPosition, Quaternion.identity);
        }
    }
}
