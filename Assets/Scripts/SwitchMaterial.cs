using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMaterial : MonoBehaviour
{
    [SerializeField] Material greenLight;
    [SerializeField] Light light;
    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (bearHeadManager.bearsDecapitated == 3)
        {
            renderer.sharedMaterial = greenLight;
            light.color = Color.green;
        }
    }
}
