using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{

    //basic bullet
    public GameObject Normal_Shot;
    //add more bullet prefabs here:
    [SerializeField]
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit lookingAt;
        Physics.Raycast(cam.transform.position, cam.transform.forward, out lookingAt, 40f);
        Debug.DrawRay(cam.transform.position, cam.transform.TransformDirection(Vector3.forward) * 40f, Color.yellow);

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 Hit = lookingAt.point;
            transform.LookAt(Hit);
            GetComponent<PlayerShoot>().Shoot( Normal_Shot);
            if(lookingAt.collider.GetComponent<EnemyHealthComponent>() != null)
            {
                lookingAt.collider.GetComponent<EnemyHealthComponent>().EnemyTakeDamage(1);
            }
            
        }
    }
}
