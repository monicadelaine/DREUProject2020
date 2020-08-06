using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codestep5 : MonoBehaviour
{
    public GameObject line5;
    public GameObject line6;

    private MeshRenderer ren5;
    private MeshRenderer ren6;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren5 = line5.GetComponent<MeshRenderer>();
            ren6 = line6.GetComponent<MeshRenderer>();

            ren5.enabled = !ren5.enabled;
            ren6.enabled = !ren6.enabled;
        }
    }
}
