using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualCollision : MonoBehaviour
{
    //public bool PotionUsed;

    //when the player collides with an object that is callled cube it will destroy it
    void OnCollisionEnter(Collision potion) {
       if (potion.gameObject.name == "Potion") {
            Destroy(potion.gameObject);

            //PotionUsed = true;
            //GetComponent<playerMovement>().doubleJump = true;
       }
       

    }
   
}
