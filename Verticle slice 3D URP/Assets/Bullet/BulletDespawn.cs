using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{
    private float _AutoDestroy = 4f;


    //Destroy if it flies out of level bounds
    private void Update()
    {
        _AutoDestroy -= Time.deltaTime;

        if(_AutoDestroy < 0)
        {
            Destroy(gameObject);
        }
    }



    //Destroy on collsion with other objects

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            Destroy( gameObject, 0.5f);
        }
        else if (collision.transform.tag == "Level")
        {
            Destroy(gameObject , 0.5f);
        }
    }
}
