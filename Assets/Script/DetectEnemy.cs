using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectEnemy : MonoBehaviour
{
    public GameObject panelEndGame;
    public GameObject leftHand;
    public GameObject rightHand;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            panelEndGame.SetActive(true);
            leftHand.SetActive(true);
            rightHand.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
