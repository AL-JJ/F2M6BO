using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wisp_Shoot : MonoBehaviour
{
    public Transform Player;
    public float _Timer;
    [HideInInspector]
    public TrackPlayer trackPlayer;
    private float range = 20f;
    [SerializeField]
    private LayerMask PlayerMask = new LayerMask();
    public GameObject FireBall_Bullet;
    private Animator anim;


    private healthComponent enemyHealth = null;
    private void Start()
    {

        _Timer = 5f;
        trackPlayer = GetComponent<TrackPlayer>();
        anim = GetComponentInParent<Animator>();
    }

    private void Update()
    {
        Player = trackPlayer.PlayerLocation;
        _Timer -= Time.deltaTime;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * range, Color.yellow);


        if (_Timer < 1f && _Timer > 0.5f)
        {
            //Play charge animation
            gameObject.transform.GetComponent<TrackPlayer>().enabled = false;
        }
        else if (_Timer <= 0f)
        {
            anim.SetBool("Shoot", true);
            gameObject.transform.GetComponent<TrackPlayer>().enabled = true;
            _Timer = 3f;
        }
    }

    
}
