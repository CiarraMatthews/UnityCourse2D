using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    bool hasPackage = false;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch");
    }

    void OnTriggerEnter2D(Collider2D other) {
        //if (the thin)
        if (other.tag == "Package")
        {
            Debug.Log("Package Picked Up");
            hasPackage = true;
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
        else {
            Debug.Log("Where is the package??");
        }
        
    }
}
