using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private Vector3 offset;
    void Awake()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        
            transform.position = target.position + offset;
        
      // movement();
    }
  /*  void movement()
    {
        float posx = player.transform.position.x;
        float posz = player.transform.position.z;

        transform.position = new Vector3(posx, transform.position.y, posz);
    }*/
}
