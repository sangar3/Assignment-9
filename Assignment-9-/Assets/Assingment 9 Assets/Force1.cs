using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force1 : MonoBehaviour
{
    private Rigidbody playerRB;

    public float ForceMult = 200;

    public ForceMode forceMode;

    private void awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
            other.attachedRigidbody.AddForce(transform.up * ForceMult * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }


}
