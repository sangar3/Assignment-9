/*
		 * (Santiago Garcia II)
		 * (MovingPlatform.cs)
		 * (Assignment 9)
		 * (Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene.)
	*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{
    public float rayDistance;
    float maxRange = 50.0f;
    float hitForce = 50.0f;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxRange))
        {

          
            rayDistance = hit.distance;

           
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            Debug.Log("Did Hit at " + hit.point);

            if (hit.rigidbody != null && Input.GetMouseButtonDown(0))
            {
                hit.rigidbody.AddForce(transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}
