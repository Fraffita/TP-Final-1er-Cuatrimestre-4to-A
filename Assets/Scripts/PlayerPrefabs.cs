using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabs : MonoBehaviour
{
    
  bool tocado;
    float posZ;
    public GameObject prefab;

    void Start()
    {
     
        posZ = Random.Range(-6.5f, 5.5f);
    }

   
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "escalon")
        {

          // Debug.Log("1");
           // Instantiate(prefab, new Vector3(prefab.transform.position.x - 8, prefab.transform.position.y, posZ), Quaternion.identity);
           // prefab.GetComponent<Renderer>().material = Verde;
          // tocado = true;


        }
    }

  /*  IEnumerator cambiocolor()
    {
        yield return new WaitForSeconds(3f);
        prefab.GetComponent<Renderer>().material = Rojo;
        Destroy(prefab, 1);
    } */
}
