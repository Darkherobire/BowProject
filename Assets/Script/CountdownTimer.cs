using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float Timeleft;
    public bool TimerOn = false;

    public Text TimerText;
    
    public GameObject panelEndGame;
    public GameObject leftHand;
    public GameObject rightHand;

    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn)
        {
            if(Timeleft > 0)
            {
                Timeleft -= Time.deltaTime;
                updateTimer(Timeleft);
            }
            else
            {
                Debug.Log("Time is UP!");
                Timeleft = 0;
                TimerOn = false;
                panelEndGame.SetActive(true);
                leftHand.SetActive(true);
                rightHand.SetActive(true);
                GameManager.Instance.EndGame();
            }
        }
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
