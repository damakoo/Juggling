using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controltimescale : MonoBehaviour
{
    public float local_timescale = 1.0f;
    GameObject Canvas;
    displaytimescale Displaytimescale;
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("OVRPlayerController/OVRCameraRig/Canvas/Text");
        Displaytimescale = Canvas.gameObject.GetComponent<displaytimescale>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        /*if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            local_timescale -= 0.05f;
            Displaytimescale.change = true;
            Displaytimescale.gravity = local_timescale;
            Displaytimescale.a_color = 0;
        }

        //if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            local_timescale += 0.05f;
            Displaytimescale.change = true;
            Displaytimescale.gravity = local_timescale;
            Displaytimescale.a_color = 0;
        }*/
    }
}