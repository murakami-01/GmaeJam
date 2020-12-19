using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
          if(a == 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
                a = 1;

            }  else if(a == 1)
            
                GetComponent<Renderer>().material.color = Color.blue;
                a = 2;
            }
            else if (a == 2)
            {
                GetComponent<Renderer>().material.color = Color.green;
                a = 3;
            }
            else if (a == 3)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
                a = 0;
            }

        }


    }
