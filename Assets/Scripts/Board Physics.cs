using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPhysics : MonoBehaviour
{
    [SerializeField] Rigidbody boardPhysics;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("crowbar end"))
        {
            boardPhysics.isKinematic = false;
            this.GetComponent<BoxCollider>().enabled = false;
        }

    }
}
