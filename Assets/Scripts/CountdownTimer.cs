using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        
        startingtime = 150f;
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
            
            checkgameobject();
            endtime = 0;
        }
        
    }
    private void checkgameobject()
    {
        if(car.activeSelf)
        {
            
            WinPanel.SetActive(true);
        }
       
    }
}
