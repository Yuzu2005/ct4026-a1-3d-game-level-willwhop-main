using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionForce : MonoBehaviour {
    public float explosionForce;
    public float fieldOfImpact;

    //when the player collides into the object it will destroy it after 0.2 seconds
    void OnCollisionEnter(Collision collision) {
        Explosion();
        Destroy(gameObject, 0.2f);
    }
    
    private void Explosion() {
        //when the collider is hit determin the feild of impact from that position
        Collider[] collider = Physics.OverlapSphere(transform.position, fieldOfImpact);
        foreach(Collider target in collider) {
            //gets the rigidbody of the collider
            Rigidbody rb = target.GetComponent<Rigidbody>();
            //checks if theres a rigidbody
            if (rb != null) {
                //add force
                rb.AddExplosionForce(explosionForce, transform.position, fieldOfImpact, 0.2f);
            }
        }
        
    }
    
}
