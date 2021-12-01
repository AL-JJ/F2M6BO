using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLookat : MonoBehaviour
{
    Transform camera;
    
    private void Start()
    {
        camera = Camera.main.transform;
    }
    void Update()
    {

        //zorg ervoor dat het object niet rare rotaties maakt om naar de cam te kijken

        float xRotation = transform.rotation.x;
        float yRotation = transform.rotation.y;
        //xRotation = Mathf.Clamp(0, 0f, 20f);
        //yRotation = Mathf.Clamp(0, -30f, 30f);

            camera = Camera.main.transform;
            transform.LookAt(camera);
        
          

    }
}
