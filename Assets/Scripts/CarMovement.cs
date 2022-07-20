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
        mybody.velocity = transform.forward * speed;
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
}

