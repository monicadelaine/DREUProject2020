using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codestep4 : MonoBehaviour
{
    public GameObject line4;
    public GameObject line5;

    private MeshRenderer ren4;
    private MeshRenderer ren5;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren4 = line4.GetComponent<MeshRenderer>();
            ren5 = line5.GetComponent<MeshRenderer>();

            ren4.enabled = !ren4.enabled;
            ren5.enabled = !ren5.enabled;
        }
    }
}
