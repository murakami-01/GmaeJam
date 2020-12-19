using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTutorial : MonoBehaviour
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
        if(other.gameObject.tag == "Camera")
        {
            Destroy(this.gameObject);
            GetComponent<AudioSource>().Play();

        }
      

    }
}
