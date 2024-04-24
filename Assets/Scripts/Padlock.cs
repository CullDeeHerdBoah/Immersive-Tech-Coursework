using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padlock : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;

    // Start is called before the first frame update
    void Start()
    {
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bearHeadManager.bearsDecapitated == 3)
        {
            door.GetComponent<Rigidbody>().isKinematic = false; 
            handle.GetComponent<BoxCollider>().enabled = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
