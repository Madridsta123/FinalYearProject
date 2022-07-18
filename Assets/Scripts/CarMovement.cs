using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField]
    private float rotationspeed;
    [SerializeField]
   private float speed;

    public Rigidbody mybody;
    private int currentAngle;

    public float Speed{get{return speed;} }
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = transform.forward * speed;
    }
}
