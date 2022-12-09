using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public GameObject KunaiPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send Kunai
        if (Input.GetKeyDown(KeyCode.Space))
    {
         Instantiate(KunaiPrefab, transform.position, KunaiPrefab.transform.rotation);
    }
       
     }

   
}
