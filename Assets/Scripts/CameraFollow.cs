using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private Vector3 offset;
    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target)
        {
            transform.position = target.transform.position + offset;
        }
      // movement();
    }
  /*  void movement()
    {
        float posx = player.transform.position.x;
        float posz = player.transform.position.z;

        transform.position = new Vector3(posx, transform.position.y, posz);
    }*/
}
