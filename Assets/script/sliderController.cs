using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
 
public class Test : MonoBehaviour
{
 
    Slider hpSlider;
 
    // Use this for initialization
    void Start()
    {
 
        hpSlider = GetComponent<Slider>();
 
        float nowHp = 100f;

        hpSlider.value = nowHp;
 
        
    }
 
    // Update is called once per frame
    void Update()
    {
        
    }
 
 
}