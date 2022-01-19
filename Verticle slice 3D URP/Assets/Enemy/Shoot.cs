using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : TrackPlayer
{
    public Transform Player;
    public float _Timer;
    [HideInInspector]
    public TrackPlayer trackPlayer;
    private float range = 20f;

    private void Start()
    {
        
        _Timer = 5f;
        trackPlayer= GetComponent<TrackPlayer>();
    }

    private void Update()
    {
        Player = trackPlayer.PlayerLocation;
        _Timer -= Time.deltaTime;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * range, Color.yellow);


        if (_Timer < 1f && _Timer > 0.5f ) 
        {
            //Play charge animation
            gameObject.transform.GetComponent<TrackPlayer>().enabled = false;
        }
        if (_Timer < 0f)
        {
            RaycastHit hit;
            Ray landing = new Ray(gameObject.transform.position, Vector3.forward);
           
            if (Physics.Raycast(landing, out hit, range))
            {
                if(hit.collider.tag == "Player")
                {
                     //Player take damage
                    hit.transform.GetComponent<healthComponent>().TakeDamage();
                }
               
            }

            gameObject.transform.GetComponent<TrackPlayer>().enabled = true;
            _Timer = 3f;
        }
    }
}
