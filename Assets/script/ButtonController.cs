using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;
public class ButtonController : MonoBehaviour
{
    float arg=0.0f;
    public Slider slider;
    public Transform parent;
    public Button btn;
    public int initialCoinNum=100;
    public static int coinNum=100;
     double vec_x;
    double vec_y;
    double vec_z;
    public stockController script;
    // Start is called before the first frame update
    void Start()
    {
        //coinNum=coinController.plusCoinNum();
      
      for (int i=-9;i<=11;i=i+2){
        for(int j=0;j<=30;j=j+2){
          float x = i;
        float z = j;
        GameObject obj = (GameObject)Resources.Load ("coin");
          Rigidbody rb = obj.transform.GetComponent<Rigidbody> ();
      //parent=GameObject.Find("moveBoard").transform;
       Debug.Log("x:" + x + " z:" + z);
        Instantiate (obj, new Vector3(x,-23.0f,z), Quaternion.Euler(90.0f, 0.0f, 0.0f),parent);
        }
      }
    //   for (int n = 0; n < 10; n++)
    //   {
    //     Random r1 = new System.Random();
    //     // ランダムの位置
    //    float x = r1.Next(-5,14);
    //     float z = r1.Next(0,30);
 
    // // ボックスとアイテムが重ならないとき
   
    // GameObject obj = (GameObject)Resources.Load ("coin");
    //       Rigidbody rb = obj.transform.GetComponent<Rigidbody> ();
    //   //parent=GameObject.Find("moveBoard").transform;
    //    Debug.Log("x:" + x + " z:" + z);
    //     Instantiate (obj, new Vector3(x,-23.0f,z), Quaternion.Euler(90.0f, 0.0f, 0.0f),parent);
    // }
    }
    // Update is called once per frame
    void Update()
    {
        
        arg = slider.value;
    }
      public void OnClick()
    {
        this.script = FindObjectOfType<stockController>(); 
           coinNum = script.Score; 
           
        if(coinNum>0){
         coinNum=coinNum-1;
         script.Score = coinNum; 
         GameObject obj = (GameObject)Resources.Load ("coin");
          Rigidbody rb = obj.transform.GetComponent<Rigidbody> ();
        
        Instantiate (obj, new Vector3(7.63f,6.68f,-19.41f), Quaternion.Euler(0.0f, 90f+arg, 0.0f),parent);
         vec_x=11125*Math.Sin(arg * (Math.PI / 180));
        vec_y=11125*Math.Cos(arg * (Math.PI / 180));
        vec_z=11125*Math.Sin(25 * (Math.PI / 180));
         rb.velocity  = new Vector3 ( (float)vec_x,(float)vec_y,  (float)vec_z);
        Debug.Log(rb.velocity);
        btn.interactable = false;
        Invoke(nameof(isAbleClick), 0.5f);

        }
    }
    void isAbleClick()
    {
       btn.interactable = true;
    }
    public static int getCoinNum(){
		return coinNum;
	}

}
