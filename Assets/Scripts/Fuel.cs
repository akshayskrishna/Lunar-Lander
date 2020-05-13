using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{
    public Text fuel;
    int total = 300;
    string none;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            if (total > 0)
            {
                total--;
                fuel.text = total.ToString();
            }

            else
            {
                none = "NO FUEL";
                fuel.text = none;
            }


        }

        

            

        }
        }

    

