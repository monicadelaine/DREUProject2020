using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeStepReset : MonoBehaviour
{
    public GameObject line8;
    public GameObject line1;

    private MeshRenderer ren8;
    private MeshRenderer ren1;

    void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
            ren8 = line8.GetComponent<MeshRenderer>();
            ren1 = line1.GetComponent<MeshRenderer>();

            ren8.enabled = !ren8.enabled;
            ren1.enabled = !ren1.enabled;
        }
    }
}
