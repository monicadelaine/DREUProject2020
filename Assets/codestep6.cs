using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codestep6 : MonoBehaviour
{
    public GameObject line6;
    public GameObject line7;

    private MeshRenderer ren6;
    private MeshRenderer ren7;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren6 = line6.GetComponent<MeshRenderer>();
            ren7 = line7.GetComponent<MeshRenderer>();

            ren6.enabled = !ren6.enabled;
            ren7.enabled = !ren7.enabled;
        }
    }
}
