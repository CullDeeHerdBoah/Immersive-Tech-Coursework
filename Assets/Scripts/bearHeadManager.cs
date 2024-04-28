using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearHeadManager : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    public static int bearsDecapitated;
    private bool doorUnlocked;

    // Start is called before the first frame update
    void Start()
    {
        bearsDecapitated = 0;
        doorUnlocked = false;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(bearsDecapitated == 3 && doorUnlocked == false)
        {
            UnlockExit();
            doorUnlocked=true;
        }
    }

    private void UnlockExit()
    {
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
    }
}
