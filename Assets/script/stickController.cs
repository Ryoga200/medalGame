using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stickController : MonoBehaviour
{
    // Start is called before the first frame update
    float arg=0.0f;
    public Slider slider;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        arg = slider.value;
       // Transform myTransform = this.transform;
       // myTransform= Quaternion.Euler(0, arg, 0);
        transform.rotation = Quaternion.Euler(0, arg, 0); // // X軸を中心に45°回転
       Debug.Log(arg);
    }
}
