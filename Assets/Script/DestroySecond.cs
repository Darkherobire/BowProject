using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DestroySecond : MonoBehaviour
{
    [FormerlySerializedAs("DestroyDelay")] [SerializeField]
    private int destroyDelay = 20;

    // Update is called once per frame
    void Update()
    { 
        Destroy(gameObject, 20);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
