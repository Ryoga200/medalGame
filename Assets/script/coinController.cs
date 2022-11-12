using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class coinController : MonoBehaviour
{
    private bool accel = false;
    double vec_x;
    double vec_y;
    double vec_z;
    public static int  plusNum=1000;
    public stockController script;
    private Vector3 _prevPosition;
    // Start is called before the first frame update
    void Start()
    {
      Rigidbody rb = this.transform.GetComponent<Rigidbody> (); 
       rb.drag=0.9f;
        rb.angularDrag=0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.transform.GetComponent<Rigidbody> (); 
         Transform myTransform = this.transform;
             if(accel){
          if(rb.velocity.y>-4.0f){
            rb.AddForce(new Vector3(0,-0.5f,0.5f),ForceMode.VelocityChange);
          }else{
            //accel=false;
          }
        }
        
        //Debug.Log(plusCoinNum.ToString());
       
    }
void FixedUpdate() {
      
    }
    void OnCollisionEnter(Collision collision)
{
   Rigidbody rb = this.transform.GetComponent<Rigidbody> (); 
    // if(accel){
    //     Rigidbody rb = this.transform.GetComponent<Rigidbody> (); 
    //     // // 現在位置取得
    //     // var position = transform.position;

    //     // // 現在速度計算
    //     // var velocity = (position - _prevPosition) / Time.deltaTime;

    //     // // 現在速度をログ出力
    //     // print($"velocity = {velocity}");
    //     // // 前フレーム位置を更新
    //     // _prevPosition = position;
     
    // }

      Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得
      if(collision.gameObject==GameObject.Find("coin")){
         accel=false;
      }
      if(collision.gameObject.name=="Cube"){
        Debug.Log("aaaaaaaaaaaaaa");
         accel=true;
      }
      if((collision.gameObject.name=="board" || collision.gameObject.name=="wall" || collision.gameObject.name=="coin")&&(this.gameObject.transform.parent.name=="stick" || this.gameObject.transform.parent.name == null)){
       // Debug.Log(this.gameObject.transform.parent.name);
           rb = GetComponent<Rigidbody>(); 
            rb.constraints = RigidbodyConstraints.None;
        rb.drag=0.3f;
        rb.angularDrag=0.4f;
        this.gameObject.transform.parent=GameObject.Find("moveBoard").transform;
        accel=false;
      }
      if(collision.gameObject.name=="stayBoard"){
        this.gameObject.transform.parent=GameObject.Find("stayBoard").transform;
      }
      // if(collision.gameObject.name=="wall"){
      //    rb.constraints = RigidbodyConstraints.FreezeAll;
      // }
      if(collision.gameObject.name=="out"){
        Destroy(this.gameObject);
      }
      if(collision.gameObject.name=="in"){
        //Debug.Log("aaaaaaaaaa");
         this.script = FindObjectOfType<stockController>(); 
        plusNum = script.Score;
        plusNum=plusNum+1;
        script.Score = plusNum; 
         //Debug.Log(plusNum); 
        Destroy(this.gameObject);
      }
     
}
  public static int plusCoinNum(){
		return plusNum;
	}
    // void OnCollisionExit(Collision collision){
    //     Rigidbody rb = this.transform.GetComponent<Rigidbody> (); 
    //         if(collision.gameObject.name=="wall"){
    //      rb.constraints = RigidbodyConstraints.None;

    //   }
    // }
}
