using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    private bool onGround;
    private float friction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EvaluateCollision(Collision collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            Vector3 normal = collision.GetContact(i).normal;
            onGround |= normal.y > 0.9f;
        }
    }

    private void RetrieveFriction(Collision collision)
    {
        PhysicMaterial material = collision.collider.sharedMaterial;

        friction = 0;

        if(material != null)
        {
            friction = material.dynamicFriction;
        }
    }
}
