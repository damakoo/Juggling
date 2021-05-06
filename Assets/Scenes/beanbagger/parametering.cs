using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class parametering : MonoBehaviour
{

    [SerializeField] GameObject _righthand;
    [SerializeField] GameObject _RSphere;
    [SerializeField] GameObject _GSphere;
    [SerializeField] GameObject _BSphere;

    [SerializeField] Text _timescale_minus;
    [SerializeField] Text _timescale_plus;
    [SerializeField] Text _timescale_value;
    
    [SerializeField] Text _ballsize_minus;
    [SerializeField] Text _ballsize_plus;
    [SerializeField] Text _ballsize_value;

    [SerializeField] Text _fix;
    [SerializeField] Text _free;
    [SerializeField] Text _orbital_minus;
    [SerializeField] Text _orbital_plus;
    [SerializeField] Text _orbital_value;

    [SerializeField] Text _reset_text;
    [SerializeField] Image _reset_image;

    [SerializeField] controltimescale _controltimescale;

    private int timescalevalue = 100;
    private int ballsizevalue = 100;
    public int orbitalvalue = 60;

    private bool hit_parameter = false;
    private bool hit_timescale_minus = false;
    private bool hit_timescale_plus = false;
    private bool hit_ballsize_minus = false;
    private bool hit_ballsize_plus = false;
    private bool hit_fix = false;
    private bool hit_free = false;
    private bool hit_orbital_minus = false;
    private bool hit_orbital_plus = false;
    private bool hit_reset = false;
    public bool fixing = false; 



    // Start is called before the first frame update
    void Start()
    {
        _RSphere.GetComponent<fixorbit>().enabled = false;
        _GSphere.GetComponent<fixorbit>().enabled = false;
        _BSphere.GetComponent<fixorbit>().enabled = false;
        _free.color = Color.blue;

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(_righthand.transform.position, _righthand.transform.forward);

        _righthand.GetComponent<LineRenderer>().SetPosition(0, _righthand.transform.position);

        foreach (RaycastHit hit in Physics.RaycastAll(ray))
        {
            if (hit.collider.gameObject.name == "Plane_parameter")
            {
                hit_parameter = true;
                _righthand.GetComponent<LineRenderer>().SetPosition(1, _righthand.transform.position + _righthand.transform.forward * 100);
            }
            else if (hit.collider.gameObject.name == "timescale_minus")
            {
                _timescale_minus.color = Color.red;
                hit_timescale_minus = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _controltimescale.local_timescale -= 0.05f;
                    timescalevalue -= 5;
                    _timescale_value.text = "×" + 
                        ((float)timescalevalue / 100).ToString("f2");
                }

            }
            else if (hit.collider.gameObject.name == "timescale_plus")
            {
                _timescale_plus.color = Color.red;
                hit_timescale_plus = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _controltimescale.local_timescale += 0.05f;
                    timescalevalue += 5;
                    _timescale_value.text = "×" + ((float)timescalevalue / 100).ToString("f2");
                }

            }
            else if (hit.collider.gameObject.name == "ballsize_minus")
            {
                _ballsize_minus.color = Color.red;
                hit_ballsize_minus = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.transform.localScale -= new Vector3(0.0005f, 0.0005f, 0.0005f);
                    _GSphere.transform.localScale -= new Vector3(0.0005f, 0.0005f, 0.0005f);
                    _BSphere.transform.localScale -= new Vector3(0.0005f, 0.0005f, 0.0005f);
                    ballsizevalue -= 5;
                    _ballsize_value.text = ((float)ballsizevalue / 100).ToString("f2");
                }
            }
            else if (hit.collider.gameObject.name == "ballsize_plus")
            {
                _ballsize_plus.color = Color.red;
                hit_ballsize_plus = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.transform.localScale += new Vector3(0.0005f, 0.0005f, 0.0005f);
                    _GSphere.transform.localScale += new Vector3(0.0005f, 0.0005f, 0.0005f);
                    _BSphere.transform.localScale += new Vector3(0.0005f, 0.0005f, 0.0005f);
                    ballsizevalue += 5;
                    _ballsize_value.text = ((float)ballsizevalue / 100).ToString("f2");
                }
            }
            else if (hit.collider.gameObject.name == "fix")
            {
                _fix.color = Color.red;
                hit_fix = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.GetComponent<fixorbit>().enabled = true;
                    _GSphere.GetComponent<fixorbit>().enabled = true;
                    _BSphere.GetComponent<fixorbit>().enabled = true;
                    fixing = true;
                }
            }
            else if (hit.collider.gameObject.name == "free")
            {
                _free.color = Color.red;
                hit_free = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.GetComponent<fixorbit>().enabled = false;
                    _GSphere.GetComponent<fixorbit>().enabled = false;
                    _BSphere.GetComponent<fixorbit>().enabled = false;
                    fixing = false;
                }
            }
            else if (hit.collider.gameObject.name == "orbital_minus")
            {
                _orbital_minus.color = Color.red;
                hit_orbital_minus = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.GetComponent<fixorbit>().throwtime -= 0.05f;
                    _GSphere.GetComponent<fixorbit>().throwtime -= 0.05f;
                    _BSphere.GetComponent<fixorbit>().throwtime -= 0.05f;
                    orbitalvalue -= 5;
                    _orbital_value.text = ((float)orbitalvalue / 100).ToString("f2");
                }
            }
            else if (hit.collider.gameObject.name == "orbital_plus")
            {
                _orbital_plus.color = Color.red;
                hit_orbital_plus = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.GetComponent<fixorbit>().throwtime += 0.05f;
                    _GSphere.GetComponent<fixorbit>().throwtime += 0.05f;
                    _BSphere.GetComponent<fixorbit>().throwtime += 0.05f;
                    orbitalvalue += 5;
                    _orbital_value.text = ((float)orbitalvalue / 100).ToString("f2");
                }
            }
            else if (hit.collider.gameObject.name == "reset_image")
            {
                _reset_text.color = Color.red;
                hit_reset = true;
                if (OVRInput.GetDown(OVRInput.Button.One))
                {
                    _RSphere.gameObject.GetComponent<Transform>().position = new Vector3(-0.3f, 1.164f, -0.236f);
                    _GSphere.gameObject.GetComponent<Transform>().position = new Vector3(-0.2f, 1.164f, -0.236f);
                    _BSphere.gameObject.GetComponent<Transform>().position = new Vector3(-0.1f, 1.164f, -0.236f);
                    _RSphere.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    _GSphere.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    _BSphere.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                }
            }
        }

        if (!hit_parameter)
        {
            _righthand.GetComponent<LineRenderer>().SetPosition(1, _righthand.transform.position);
        }
        else
        {
            hit_parameter = false;
        }

        if (!hit_timescale_minus)
        {
            _timescale_minus.color = Color.black;
        }
        else
        {
            hit_timescale_minus = false;
        }

        if (!hit_timescale_plus)
        {
            _timescale_plus.color = Color.black;
        }
        else
        {
            hit_timescale_plus = false;
        }

        if (!hit_ballsize_minus)
        {
            _ballsize_minus.color = Color.black;
        }
        else
        {
            hit_ballsize_minus = false;
        }

        if (!hit_ballsize_plus)
        {
            _ballsize_plus.color = Color.black;
        }
        else
        {
            hit_ballsize_plus = false;
        }

        if (!hit_orbital_minus)
        {
            _orbital_minus.color = Color.black;
        }
        else
        {
            hit_orbital_minus = false;
        }

        if (!hit_orbital_plus)
        {
            _orbital_plus.color = Color.black;
        }
        else
        {
            hit_orbital_plus = false;
        }

        if (!hit_fix)
        {
            if (!fixing)
            {
                _fix.color = Color.black;
            }
            else
            {
                _fix.color = Color.blue;
            }
        }
        else
        {
            hit_fix = false;
        }

        if (!hit_free)
        {
            if (fixing)
            {
                _free.color = Color.black;
            }
            else
            {
                _free.color = Color.blue;
            }
        }
        else
        {
            hit_free = false;
        }

        if (!hit_reset)
        {
            _reset_text.color = Color.black;
        }
        else
        {
            hit_reset = false;
        }
    }
}
