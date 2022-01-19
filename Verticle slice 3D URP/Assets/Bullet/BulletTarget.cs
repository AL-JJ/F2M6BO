using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTarget : MonoBehaviour { 

    private float speed =12f;
    private float range = 7f;
    private float timeBeforeShot = 1f;

    public void GetTarget(Transform Target)
    {
        //raycast trekt een rechte lijn en kijk met welke colliders het collide
        transform.LookAt(Target);
        
        timeBeforeShot -= Time.deltaTime;

        if(timeBeforeShot <= 0)
        {
            RaycastHit hit;
            Ray landing = new Ray(transform.position, Vector3.forward);

            if (Physics.Raycast(landing, out hit, range))
            {
                print("hit");
            }
        }
    }
    
}
