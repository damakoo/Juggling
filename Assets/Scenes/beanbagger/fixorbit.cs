using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chronos;
using System;
using UnityEngine.UI;

public class fixorbit : BaseBehaviour
{
    OVRGrabbable _ovrgrababble;

    [SerializeField] public float throwtime = 1.0f;
    [SerializeField] GameObject _righthand;
    [SerializeField] GameObject _lefthand;
    Vector3 right_hand_pos;
    Vector3 left_hand_pos;
    Vector3 throwvec;

    private bool tossing = false;
    private bool right_hand = true;

    
    // public Clock clock = Timekeeper.instance.Clock(Root.ToString()); 
    // Start is called before the first frame update
    void Start()
    {
        _ovrgrababble = this.gameObject.GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_ovrgrababble.isGrabbed)
        {
            tossing = true;
            if (_ovrgrababble.grabbedBy.name == "DistanceGrabHandRight")
            {
                right_hand = true;
            }
            else
            {
                right_hand = false;
            }

        }
        else
        {
            if (tossing)
            {
                right_hand_pos = _righthand.transform.position;
                left_hand_pos = _lefthand.transform.position;
                if (right_hand)
                {
                    throwvec = new Vector3((left_hand_pos.x - right_hand_pos.x) / throwtime, (left_hand_pos.y - right_hand_pos.y) / throwtime - Physics.gravity.y * throwtime / 2, (left_hand_pos.z - right_hand_pos.z) / throwtime);
                }
                else
                {
                    throwvec = new Vector3((right_hand_pos.x - left_hand_pos.x) / throwtime, (right_hand_pos.y - left_hand_pos.y) / throwtime - Physics.gravity.y * throwtime / 2, (right_hand_pos.z - left_hand_pos.z) / throwtime);
                }
                this.GetComponent<Rigidbody>().velocity = throwvec;
                tossing = false;
            }
        }

    }
}
