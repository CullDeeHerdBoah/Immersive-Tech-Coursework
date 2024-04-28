using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padlock : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    [SerializeField] Rigidbody padlockphysics;
    [SerializeField] AudioClip keyUsed;
    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("key"))
        {
            other.gameObject.SetActive(false);
            AudioManager.cue.PlaySound(keyUsed);
            mAnimator.SetTrigger("padlock turn");
        }
    }

    public void UnlockDoor()
    {
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<BoxCollider>().enabled = false;
        padlockphysics.isKinematic = false;
    }
}
