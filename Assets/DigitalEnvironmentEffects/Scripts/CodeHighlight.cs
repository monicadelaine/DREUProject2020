using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeHighlight : MonoBehaviour
{
    public GameObject line1;
    public GameObject line2;

    private MeshRenderer ren1;
    private MeshRenderer ren2;
  void OnTriggerEnter(Collider button)
    {
        if (button.CompareTag("Player"))
        {
           
            ren1 = line1.GetComponent<MeshRenderer>();
            ren2 = line2.GetComponent<MeshRenderer>();

            ren1.enabled = !ren1.enabled;
            ren2.enabled = !ren2.enabled;
        }
    }
 
}
