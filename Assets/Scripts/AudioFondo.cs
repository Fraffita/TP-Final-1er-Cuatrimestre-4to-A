using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFondo : MonoBehaviour
{
    AudioSource source;
    private int isplaying = 0;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isplaying = isplaying +1;

            if (isplaying == 1)
            {
                source.Play();
            }
        }

        

    }
}
