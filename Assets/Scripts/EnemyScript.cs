using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 30, rotatingspeed = 8;
    public GameObject target;
    public Rigidbody mybody;
    public GameObject cash;
    public GameObject explosion;
    public GameObject LosePanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
        mybody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target==null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
            return;

        }
        Vector3 point = transform.position - target.transform.position;
        point.Normalize();

        float value = Vector3.Cross(point, transform.forward).y;
            
        mybody.angularVelocity = rotatingspeed * value*new Vector3(0, 1, 0);
        mybody.velocity = transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //When collision with car
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosion, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
            Destroy(collision.gameObject);
            Destroy(gameObject);
            LosePanel.SetActive(true);
                

        }
        //When Collides with tower
        if(collision.gameObject.CompareTag("Tower"))
        {
            Destroy(gameObject);
        }
       //When one enemy collides with another enemy
        if(collision.gameObject.CompareTag("Enemy"))
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
