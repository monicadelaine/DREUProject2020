using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codestep3 : MonoBehaviour
{
    public GameObject line3;
    public GameObject line4;

    private MeshRenderer ren3;
    private MeshRenderer ren4;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren3 = line3.GetComponent<MeshRenderer>();
            ren4 = line4.GetComponent<MeshRenderer>();

            ren3.enabled = !ren3.enabled;
            ren4.enabled = !ren4.enabled;
        }
    }
}
