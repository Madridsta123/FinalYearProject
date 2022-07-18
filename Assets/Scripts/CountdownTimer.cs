using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField]private  float endtime;
    [SerializeField] private float startingtime;

    [SerializeField] TextMeshProUGUI countdowntext;
    // Start is called before the first frame update
    void Start()
    {
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
        }

    }
}
