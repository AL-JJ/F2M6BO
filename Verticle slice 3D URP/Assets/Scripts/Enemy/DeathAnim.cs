using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour
{

    public void Death()
    {
        Destroy(gameObject, 0.5f);
    }
}
