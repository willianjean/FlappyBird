using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

    bool fruitCheck = false;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Fruit")
        {
            fruitCheck = true;
        }
        
    }
    
    private void OnTriggerEnter2D (Collider2D other)
    {

        if (other.GetComponent<Bird>() != null)//other.GetComponent<Bird>() != null    -      other.tag == "Fruit"
        {

            GameControl.instance.BirdScored();
            
        }
        
    }

	
}
