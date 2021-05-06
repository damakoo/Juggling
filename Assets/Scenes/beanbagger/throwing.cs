using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    [SerializeField] parametering _Parametering;
    OVRGrabbable _OVRGrabbable;
    private bool isgrabbing = false;
    List<float> _ypos = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        _OVRGrabbable = this.GetComponent<OVRGrabbable>();
        for(int i = 0; i < 5; i++)
        {
            _ypos.Add(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _ypos.RemoveAt(0);
        _ypos.Add(this.transform.position.y);
        

        if(_OVRGrabbable.isGrabbed && !isgrabbing)
        {
            isgrabbing = true;
        }
        else if(!_OVRGrabbable.isGrabbed && isgrabbing && !_Parametering.fixing && _ypos[3] > _ypos[0])
        {
            isgrabbing = false;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0,(float)_Parametering.orbitalvalue * (_ypos[3] -_ypos[0]) / 0.6f,0));
        }
        else if(!_OVRGrabbable.isGrabbed && isgrabbing)
        {
            isgrabbing = false;
        }
    }
}
