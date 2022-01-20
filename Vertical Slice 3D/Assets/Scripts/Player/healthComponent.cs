using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthComponent : MonoBehaviour
{

    public static float curHealth = 100f;
    public static float maxHealth = 100f;
    public static float LemuriandecHealth = 10f;
    public static float regHealth = 2f;

    void Start()
    {
        curHealth = 98f;
    }

    void Update()
    {
        if (curHealth < maxHealth)
        {
            curHealth += regHealth * Time.deltaTime;
            print(curHealth);
        }

        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (gameObject.tag == "Player")
        {
            curHealth -= LemuriandecHealth;
            print(curHealth);
        }
    }

}
