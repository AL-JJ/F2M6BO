using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoundCheck : MonoBehaviour
{
    [SerializeField]
    private float maxDistance = 10f;
    [SerializeField]
    private Rigidbody rb;
    RaycastHit hit;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, -3, 0);
        Ray Pos = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * maxDistance, Color.yellow);

        if(Physics.Raycast(Pos, out hit, maxDistance))
        {
            if(hit.collider.tag == "Enironment")
            {
                float DistanceToGround = Vector3.Distance(transform.position, hit.transform.position);
                if (DistanceToGround < maxDistance)
                {
                    rb.velocity = new Vector3(0, 3, 0);
                }
            }
        }
    }
}
