using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    public Text fuel;
    int total = 300;
    string none;
    Rigidbody2D rb;
    Vector2 force;
    AudioSource audiosource;
    public AudioClip clipJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        double v = -0.5d + Time.deltaTime;
        double c = 0.5d + Time.deltaTime;
        //rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, v, c), rb.velocity.y);

        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, (float)-0.5d + Time.deltaTime, (float)0.5d + Time.deltaTime), rb.velocity.y);

        Vector2 vector2 = force = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            if (total > 0)
            {
                total--;
                fuel.text = total.ToString();
                force.x = (float)0.05 + Time.deltaTime;
            }

            else
            {
                none = "NO FUEL";
                fuel.text = none;
                force.x = 0;

            }
        }

    

        else if (Input.GetKey(KeyCode.D))
        {
            if (total > 0)
            {
                total--;
                fuel.text = total.ToString();
                force.x = (float)-0.05 + Time.deltaTime;
            }
            else
            {
                none = "NO FUEL";
                fuel.text = none;
                force.x = 0;

            }
        }

        else if (Input.GetKey(KeyCode.S))
        {
            if (total > 0)
            {
                total--;
                fuel.text = total.ToString();

                force.y = (float)0.01 + Time.deltaTime;
            }
            else
            {
                none = "NO FUEL";
                fuel.text = none;
                force.y = 0;

            }

            audiosource.clip = clipJump;
            audiosource.Play();
        }
    }




    private void FixedUpdate()
    {
        rb.AddForce(force);
    }

}
