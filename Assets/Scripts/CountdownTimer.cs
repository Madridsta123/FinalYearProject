using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private float endtime;
    [SerializeField] private float startingtime;
    [SerializeField] private GameObject car;
    [SerializeField] TextMeshProUGUI countdowntext;
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject LosePanel;
    [SerializeField] private GameObject explosion;
   
    private void Awake()
    {
       /*Se[] scenes = SceneManager.GetAllScenes();

        foreach(Scene sc in scenes)
        {
            startingtime--;
        }*/

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            startingtime = 10f;
        }

     else if (SceneManager.GetActiveScene().name=="TEST")
        {
            startingtime = 5f;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        WinPanel.SetActive(false);
        LosePanel.SetActive(false);
        endtime = startingtime;
       

    }

    // Update is called once per frame
    void Update()
    {
        endtime -= 1 * Time.deltaTime;
        countdowntext.text = endtime.ToString("0");

        if (endtime <= 0)
        {
            
           
            endtime = 0;
            checkgameobject();
        }
        
    }
    private void checkgameobject()
    {
        if (car.activeInHierarchy==true) {
            WinPanel.SetActive(true);
            StartCoroutine(LoadNextScene());
        }
        //if(car.activeSelf)
        //{          
            
        //}
       
       
    }
    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Test");

    }
    
}
