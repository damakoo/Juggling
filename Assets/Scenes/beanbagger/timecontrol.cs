using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;
using System;

public class timecontrol : BaseBehaviour
{
    public enum root
    {
        RootR,
        RootG,
        RootB,
    }


    public root Root;
    Clock clock;
    GameObject Sphere;
    OVRGrabbable ovrgrababble;
    controltimescale Controltimescale;

    public enum sphere0
    {
        RSphere,
        GSphere,
        BSphere,

    }
    public sphere0 sphere;

    

    // public Clock clock = Timekeeper.instance.Clock(Root.ToString()); 
    // Start is called before the first frame update
    void Start()
    {

        clock = Timekeeper.instance.Clock(Root.ToString());
        Sphere = GameObject.Find("Environment/Dynamic/" + sphere.ToString());
        ovrgrababble = Sphere.gameObject.GetComponent<OVRGrabbable>();
        Controltimescale = GameObject.Find("Timekeeper").GetComponent<controltimescale>();
       

    }

    // Update is called once per frame
    void Update()
    {
        if (ovrgrababble.isGrabbed) {

            time.rigidbody.useGravity = false;
            //this.gameObject.GetComponent<Rigidbody>().useGravity = false;
            clock.localTimeScale = 1.0f;
        }
        else
        {
            time.rigidbody.useGravity = true;
            //this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            clock.localTimeScale = Controltimescale.local_timescale;
        }
        
    }
}
