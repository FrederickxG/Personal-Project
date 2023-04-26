using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
 
 private void OnTriggerEnter(Collider other)
    {

         if (other.CompareTag("Wall"))
        {
         Destroy(gameObject);
          }
        else if (other.CompareTag("Gem"))
         {
          
        Destroy(gameObject);
          Destroy(other.gameObject);
       }
    }


}