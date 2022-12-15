using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public GameObject KunaiPrefab;
    public bool gameOver = false;
    public float jumpforce = 10f;
    Rigidbody rb;
    
     // Start is called at beginning of game
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // On Q press, send Kunai
        if (Input.GetKeyDown(KeyCode.Q))
    {
         Instantiate(KunaiPrefab, transform.position, KunaiPrefab.transform.rotation);
    }
 
         // On Space press, player jumps
     if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
                
            }
        
     }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))  
        {
            gameOver = true;
            Debug.Log("Game Over");
        }
    }


   
}
