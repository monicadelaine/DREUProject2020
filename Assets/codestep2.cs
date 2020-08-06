using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codestep2 : MonoBehaviour
{
    public GameObject line2;
    public GameObject line3;

    private MeshRenderer ren2;
    private MeshRenderer ren3;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren2 = line2.GetComponent<MeshRenderer>();
            ren3 = line3.GetComponent<MeshRenderer>();

            ren2.enabled = !ren2.enabled;
            ren3.enabled = !ren3.enabled;
        }
    }
}
