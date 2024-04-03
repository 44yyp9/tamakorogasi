using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float spped = 10;
    void FixedUpdate()
    {
        // “ü—Í‚ðx‚Æz‚É‘ã“ü
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(x*spped, 0, z*spped);
        /*
        if(Input.GetKey(KeyCode.RightArrow))
        {
            x = 10;
        }
        */
    }
}
