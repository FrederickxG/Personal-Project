using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float leftLimit = -22;
    public float bottomLimit = -2;
    public float rightLimit = -27;

    // Update is called once per frame
    void Update()
    {
        // Destroy Kunai if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy Targets if y position is less than bottomLimit
         else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
        // Destroy Wall if x position more than right limit
        if (transform.position.x < rightLimit)
        {
            Destroy(gameObject);
        } 
    }
}
