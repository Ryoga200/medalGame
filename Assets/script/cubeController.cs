using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    // Start is called before the first frame update
   float vec = 1.0f;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(this.gameObject.transform.position.z>70){
            vec=-1.0f;
        }
        if(this.gameObject.transform.position.z<50){
            vec=1.0f;
        }
         this.gameObject.transform.Translate(0,0,0.1f*vec);
    }
}
