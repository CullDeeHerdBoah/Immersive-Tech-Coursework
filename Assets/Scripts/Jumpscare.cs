using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public static bool scareTriggered;
    [SerializeField] AudioClip jumpscareStinger;
    private Animator mAnimator;
    public static bool bodyFell;

    // Start is called before the first frame update
    void Start()
    {
        scareTriggered = false;
        mAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && scareTriggered == false)
        {
            StartCoroutine(scarePlayer());
        }

    }

    private IEnumerator scarePlayer()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(3);
        mAnimator.SetTrigger("Jumpscare Trigger");
        AudioManager.cue.PlaySound(jumpscareStinger);
        scareTriggered = true;

    }

    public void enableWindowBloodBlood()
    {
        bodyFell = true;
    }
}
