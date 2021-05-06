using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialization : MonoBehaviour
{
    GameObject RSphere;
    GameObject GSphere;
    GameObject BSphere;

    // Start is called before the first frame update
    void Start()
    {
        RSphere = GameObject.Find("Environment/Dynamic/RSphere");
        GSphere = GameObject.Find("Environment/Dynamic/GSphere");
        BSphere = GameObject.Find("Environment/Dynamic/BSphere");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            RSphere.gameObject.GetComponent<Transform>().position = new Vector3(-0.3f,1.164f,-0.236f);
            GSphere.gameObject.GetComponent<Transform>().position = new Vector3(-0.2f, 1.164f, -0.236f);
            BSphere.gameObject.GetComponent<Transform>().position = new Vector3(-0.1f, 1.164f, -0.236f);
            RSphere.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            GSphere.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            BSphere.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            //svelocity0
        }
    }
}
