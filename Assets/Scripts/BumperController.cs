using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    private void OnCollisionEnter(Collision collision) {
        if(collision.collider == bola){
            Debug.Log("kena bola");
        }
    }
}
