using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int seconds;
    public int minutes;
    public float currentSeconds;
    public int timerDefault;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerDefault = 0;
        timerDefault += (seconds + (minutes * 60));
        currentSeconds = timerDefault;
    }

    // Update is called once per frame
    void Update()
    {
        if((currentSeconds -= Time.deltaTime) <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Cursor.visible = true;
        }
        else
        {
            timerText.text = TimeSpan.FromSeconds(currentSeconds).ToString(@"mm\:ss");
        }
    }

    public void TimeUp()
    {
        timerText.text = "00:00";
    }
}
