using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColisionsDown : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AMMO")
        {
            ScoreManager.Instance.DownPoint();
            anim.Play("Death");
            Destroy(gameObject);
            Destroy(this.gameObject);   
        }

        if (other.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    }
    
}
