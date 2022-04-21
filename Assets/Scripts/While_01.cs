using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class While_01 : MonoBehaviour
{
    public int counter;
    public int counterMax;
    public Text txt_display;

    // Start is called before the first frame update
    void Start()
    {
        while (counter < counterMax)
        {
            Debug.Log(counter);
            counter++;
        }
        txt_display.text = ("Termino el While");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
