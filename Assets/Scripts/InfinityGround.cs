using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityGround : MonoBehaviour
{
    [SerializeField]
    private Renderer groundRenderer;
        
    [SerializeField]
    public float parallaxspeed;

    public GameObject player;
    float offsetX, offsetY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player==null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            return;
        }
        if(player!=null)
        {
            ScrollBackground(player.GetComponent<CarMovement>().Speed,groundRenderer);
        }
   
}
    private void FixedUpdate()
    {
        if(player==null)
        {
            return;
            
        }
        Movement();
    }
    void Movement()
    {
        float posX = player.transform.position.x;
        float posZ = player.transform.position.z;

        transform.position = new Vector3(posX, transform.position.y, posZ);
    }
   private  void ScrollBackground(float scrollSpeed,Renderer rend)
    {
        offsetX = transform.position.x / parallaxspeed;
        offsetY = transform.position.z / parallaxspeed;

        rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }
}
