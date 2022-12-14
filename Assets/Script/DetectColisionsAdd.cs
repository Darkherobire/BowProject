using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DetectColisionsAdd : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AMMO")
        {
            ScoreManager.Instance.AddPoint();
            Destroy(gameObject);
            Destroy(this.gameObject);   
        }

        if (other.tag == "Finish")
        {
            Destroy(this.gameObject);
        }

        if (other.tag == "Block")
        {
            Destroy(this.gameObject);
        }

    }
    
}
