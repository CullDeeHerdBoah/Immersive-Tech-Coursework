using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyfall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
        }

    }
}
