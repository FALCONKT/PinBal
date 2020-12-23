using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ScriptでUIを操作する場合　末尾に　.UI　を付す。


public class BallController : MonoBehaviour {


    //Global変数＞＞

    //Ballが見える可能性のあるz軸の最大値　float型のためfを付す
    private float visiblePosZ = -6.5f;

    //表示するテキスト
    private GameObject gameoverText;

       
    // Use this for initialization
    void Start () {

        //Sceane中のGameOverText　Objectを取得

        //Hier　View　の　Text　を取得する
        //★　Find()　Method　で見つけるというもの
        this.gameoverText = GameObject.Find("GameOverText");

    }
	
	// Update is called once per frame
	void Update () {

        //Ballが画面外に出た場合
        //y, z座標すべてに一度にアクセスしたい場合は「position」
        //x座標にアクセスしたい場合は「position.x」、
        //y座標にアクセスしたい場合は「position.y」、
        //z座標にアクセスしたい場合は「position.z」

        //　//＜　事前Ballの見える場所をしていした、宣言変数　より　
        //変化している　Ballの座標　が低い場合　という意味
        if (this.transform.position.z < this.visiblePosZ){
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }



    }
}
