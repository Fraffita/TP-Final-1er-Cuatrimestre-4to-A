using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawnpoint : MonoBehaviour
{
    public GameObject spwan;
    bool tocado;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player" && tocado == false)
        {
            spwan.transform.position = gameObject.transform.position;
        }
    }
}
