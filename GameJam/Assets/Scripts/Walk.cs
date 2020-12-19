using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);

    void walk(Vector2 V)
    {
        V = stickL;
        float Vx = 0.1f*V.x;
        float Vz = 0.1f*V.y;

        transform.Translate(Vx, 0, Vz);

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 stickL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        walk(stickL);

    }
}
