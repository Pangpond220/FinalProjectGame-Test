using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountNumber : MonoBehaviour
{
    public int Number;
    public Text Value; 
    void Start()
    {
        Value = GetComponent<Text>();
        
        //Debug.Log(Value.text);
        Number = int.Parse(Value.text);
    }

    public void Count()
    {
        Number++;

        Value.text = Number.ToString();
    }

     void Update()
     {
        //Value.text = Number.ToString();
     }
}
