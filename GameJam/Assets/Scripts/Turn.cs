using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    // Start is called before the first frame update

    int a = 0;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if(a == 0)
        {
            a = 1;

            if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft))
            {
                transform.Rotate(0, -90, 0);

            }
            if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight))
            {
                transform.Rotate(0, 90, 0);

            }
        }
        else
        {
            a = 0;

        }

       

    }

    

}
