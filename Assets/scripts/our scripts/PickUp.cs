using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool grabbed;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player2")){
            grabbed = true;
            this.transform.SetParent(other.transform, true);
        }

        if((other.gameObject.CompareTag("Cauldron"))&&(grabbed == true)){
            Destroy(this.gameObject);
        }
    }
}
