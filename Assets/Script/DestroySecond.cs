using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DestroySecond : MonoBehaviour
{
    [FormerlySerializedAs("DestroyDelay")] [SerializeField]
    private int destroyDelay = 30;

    // Update is called once per frame
    void Update()
    { 
        Destroy(gameObject, 30);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }
}
