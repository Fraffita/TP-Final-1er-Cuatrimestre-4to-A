using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEscalones : MonoBehaviour
{
    public GameObject Escalones;
    float posZ;
    float posX;

    void Start()
    {
        posZ = Random.Range(-6.5f, 5.5f);
        posX = Random.Range(-81.5f, -69f);
        Creando();
    }
    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3(-9.7f, 1.7f, posZ);
        GameObject Escalon = Instantiate(Escalones, SpawnPosition, Quaternion.identity);
       
    }

}
