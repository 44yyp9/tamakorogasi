using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemscript : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        // ÚG‘ÎÛ‚ÍPlayerƒ^ƒO‚Å‚·‚©H
        if (hit.CompareTag("Player"))
        {
            // ‰½‚ç‚©‚Ìˆ—
            Destroy(gameObject);
        }
    }
}
