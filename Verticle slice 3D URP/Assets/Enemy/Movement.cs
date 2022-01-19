using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [HideInInspector]
    public float Y_coordinate;
    public string Tag = "Player";
    [SerializeField]
    private float _Range = 13f;
    [SerializeField]
    private Rigidbody rb;
    private bool _inRange = true;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    
    void Update()
    {
        rb.velocity = new Vector3(0 ,0 ,0);
        
    }
    
    public void RangeToPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag(Tag);
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distanceToPlayer > _Range && _inRange == true)
        {
            print(distanceToPlayer);
            transform.LookAt(player.transform);
            rb.velocity = transform.forward * 4;

            _inRange = false;

            //cant shoot
        }
        else if(distanceToPlayer < _Range - 3 && _inRange == false)
        {
            // can shoot
            rb.velocity = transform.forward * 0;
            transform.rotation= Quaternion.identity;
        }
    }

    
}
