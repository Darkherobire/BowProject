using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColisionsDown : MonoBehaviour
{
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
            Destroy(gameObject);
            Destroy(this.gameObject);   
        }

        if (other.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
        
    }
    
}
