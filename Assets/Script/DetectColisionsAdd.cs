using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DetectColisionsAdd : MonoBehaviour
{
    Animator anim; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AMMO")
        {
            ScoreManager.Instance.AddPoint();
            anim.Play("Death");
            Destroy(gameObject);
            Destroy(this.gameObject);   
        }

        if (other.tag == "Finish")
        {
            GameManager.Instance.EndGame();
        }

        if (other.tag == "Block")
        {
            Destroy(this.gameObject);
        }

    }
    
}
