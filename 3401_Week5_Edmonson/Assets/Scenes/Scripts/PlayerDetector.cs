using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public Transform destination;
        void FixedUpdate()
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 5))
        {
            Debug.Log(GameObject.Find (name));
        }

        else
        {
            Debug.Log("NothingAhead");
        }
         }

    void Start()
    {
        
    }

    void Update()
    {

    }
}
