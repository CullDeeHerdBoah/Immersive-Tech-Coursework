using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBehead : MonoBehaviour
{
    [SerializeField] Rigidbody bearHeadPhysics;

        private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Knife"))
        {
            bearHeadPhysics.isKinematic = false;
            bearHeadManager.bearsDecapitated++;
        }
         
    }

}
