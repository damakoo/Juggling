using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displaytimescale : MonoBehaviour
{

    private Text targetText;
    public float gravity = 0;
    public bool change = false;
    public float a_color = 0;
    float scale;
    bool plus;
    // Start is called before the first frame update
    void Start()
    {
        this.targetText = this.GetComponent<Text>();
        this.targetText.color = new Color(0, 0, 0, 0);
        plus = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            scale = Mathf.Round(gravity*100)/100;
            this.targetText.text ="×" + scale.ToString("f2");
            if (plus)
            {
                a_color += Time.deltaTime;
                if (a_color > 1)
                {
                    plus = false;
                }

            }
            else
            {
                a_color -= Time.deltaTime;
                if (a_color < 0)
                {
                    a_color = 0;
                    change = false;
                    plus = true;
                }
            }
            this.targetText.color = new Color(0, 0, 0, a_color);

        }
    }
}
