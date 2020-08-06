using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codestep7 : MonoBehaviour
{

    public GameObject line7;
    public GameObject line8;

    private MeshRenderer ren7;
    private MeshRenderer ren8;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren7 = line7.GetComponent<MeshRenderer>();
            ren8 = line8.GetComponent<MeshRenderer>();

            ren7.enabled = !ren7.enabled;
            ren8.enabled = !ren8.enabled;
        }
    }

}
