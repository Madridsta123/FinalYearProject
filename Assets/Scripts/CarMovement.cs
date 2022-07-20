using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField]
    private float rotationspeed;
    [SerializeField]
   private float speed;
    public GameObject target;
    public GameObject explosion;
    public Rigidbody mybody;
    private int currentAngle;
    public GameObject LosePanel;
    public float Speed{get{return speed;} }
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = transform.forward * speed ;
      

        if(Input.GetMouseButtonDown(0))
        {
            float x = Input.mousePosition.x;

           if(x<Screen.width/2&& x>0)
            {
                MoveLeft();
            }
            if (x > Screen.width / 2 && x < 0)
            {
                MoveLeft();
            }
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tower"))
        {
            Instantiate(explosion, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
            target.SetActive(false);
            LosePanel.SetActive(true);
        }
    }
    void MoveLeft()
    {
        Vector3 point = transform.position;
        point.Normalize();
        float value = Vector3.Cross(point, transform.forward).y;
        mybody.angularVelocity = rotationspeed * value * new Vector3(0, -1, 0);
    }
    void MoveRight()
    {
        Vector3 point = transform.position;
        point.Normalize();
        float value = Vector3.Cross(point, transform.forward).y;
        mybody.angularVelocity = rotationspeed * value * new Vector3(0, 1, 0);
    }
}

