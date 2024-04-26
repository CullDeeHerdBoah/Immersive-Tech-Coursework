using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatPlayer : MonoBehaviour
{
    [SerializeField] Transform playerHead;

    // Update is called once per frame
    void Update()
    {

        {
            this.transform.LookAt(playerHead);
        }
    }
}
