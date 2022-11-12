using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class stockController : MonoBehaviour
{
    public int stock;
    public TextMeshProUGUI textFrame;
    // Start is called before the first frame update
    void Start()
    {
        stock=100;
    }

    // Update is called once per frame
    void Update()
    {
        
        textFrame.text = '×'+stock.ToString();
    }
    public int Score // プロパティ
   {
     get { return stock; }  // 通称ゲッター。呼び出した側がscoreを参照できる
     set { stock = value; } // 通称セッター。value はセットする側の数字などを反映する
   }
}
