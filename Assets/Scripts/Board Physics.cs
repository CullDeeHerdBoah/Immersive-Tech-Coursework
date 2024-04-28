using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPhysics : MonoBehaviour
{
    [SerializeField] Rigidbody boardPhysics;
    [SerializeField] AudioClip[] boardRemovedSounds;
    AudioClip lastPlayedSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("crowbar end"))
        {
            AudioManager.cue.PlaySound(SoundRandomiser());
            boardPhysics.isKinematic = false;
            this.GetComponent<BoxCollider>().enabled = false;
        }

    }

    AudioClip SoundRandomiser()
    {
        int attempts = 3;
        AudioClip newClip = boardRemovedSounds[Random.Range(0, boardRemovedSounds.Length)];
        while (newClip == lastPlayedSound && attempts > 0)
        {
            newClip = boardRemovedSounds[Random.Range(0, boardRemovedSounds.Length)];
            attempts--;
        }
        lastPlayedSound = newClip;
        return newClip;
    }
}
