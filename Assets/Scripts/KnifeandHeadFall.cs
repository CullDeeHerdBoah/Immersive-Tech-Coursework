using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeandHeadFall : MonoBehaviour
{
    [SerializeField] GameObject severedHead;
    private bool knifeOut;
    [SerializeField] AudioClip knifePullOut;
    [SerializeField] BoxCollider keyHitBox;
    [SerializeField] Rigidbody keyPhysics;

    // Start is called before the first frame update
    void Start()
    {
        keyHitBox.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && knifeOut == false)
        {
            knifeOut = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
            severedHead.GetComponent<Rigidbody>().isKinematic = false;
            AudioManager.cue.PlaySound(knifePullOut);
            keyHitBox.enabled = true;
            keyPhysics.isKinematic = false;

        }

    }
}

