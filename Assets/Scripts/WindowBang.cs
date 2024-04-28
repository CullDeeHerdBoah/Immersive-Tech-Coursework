using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBang : MonoBehaviour
{
    [SerializeField] GameObject bloodstain;
    [SerializeField] AudioSource windowPound;

    // Start is called before the first frame update
    void Start()
    {
        bloodstain.SetActive(false);
    }
    public void BangWindow()
    {
        if (Jumpscare.scareTriggered == true && Jumpscare.bodyFell == true)
        {
            bloodstain.SetActive(true);
            windowPound.Play();
        }

        else
        {
            return;
        }
    }
}
