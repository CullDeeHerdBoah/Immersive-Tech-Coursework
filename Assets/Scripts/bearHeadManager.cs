using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearHeadManager : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    public static int bearsDecapitated;

    // Start is called before the first frame update
    void Start()
    {
        bearsDecapitated = 0;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(bearsDecapitated == 3)
        {
            door.GetComponent<Rigidbody>().isKinematic = false;
            handle.GetComponent<BoxCollider>().enabled = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
