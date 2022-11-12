using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpinController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidbody;
    void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
    }
    void FixedUpdate(){
         rigidbody.MovePosition(this.transform.position + transform.right * Time.deltaTime);
    }
    
}
