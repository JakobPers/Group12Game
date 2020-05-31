using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Text text;
    float time;
    public float speed = 1;
  
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
            string hours = Mathf.Floor((time % 216000) / 3600).ToString("00");
            string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");
            string seconds = (time % 60).ToString("00");
            text.text = "Your surival time: " + hours + ":" + minutes + ":" + seconds;
        }
    }

