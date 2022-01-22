using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public void Shoot( GameObject SelectedBullet)
    {
        GameObject bullet = Instantiate(SelectedBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), this.gameObject.transform.rotation);
        
    }
}
