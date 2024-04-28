using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBehead : MonoBehaviour
{
    [SerializeField] Rigidbody bearHeadPhysics;
    [SerializeField] AudioClip[] beheadSounds;
    [SerializeField] BoxCollider boxCollider;
    private bool isBeheaded;
    AudioClip lastPlayedSound;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Knife") && isBeheaded == false)
        {
            AudioManager.cue.PlaySound(SoundRandomiser());
            boxCollider.enabled = false;
            bearHeadPhysics.isKinematic = false;
            bearHeadManager.bearsDecapitated = bearHeadManager.bearsDecapitated + 1;
            isBeheaded = true;

        }

    }

    AudioClip SoundRandomiser()
    {
        int attempts = 3;
        AudioClip newClip = beheadSounds[Random.Range(0, beheadSounds.Length)];
        while (newClip == lastPlayedSound && attempts > 0)
        {
            newClip = beheadSounds[Random.Range(0, beheadSounds.Length)];
            attempts--;
        }
        lastPlayedSound = newClip;
        return newClip;
    }

}
