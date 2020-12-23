using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI使用時必須


public class BallPoints : MonoBehaviour {

    //Global変数

    public Text GamePointText;
    private int score = 0;
    private int degree = 0;

    //関数
    //衝突時に呼ばれる関数　OnCollisionEnter 関数の引数()内の指定が衝突したObjectのIDを取得する
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);

        //角度を180に設定
        //→どこを触っても得点に
        //this.degree = 360;

        //ターゲットの種類は GameObject に設定したタグで判別
        //（OnCollisionEnter 関数の引数を利用することにより、
        //衝突相手の情報を取得することができます）

        //引数は　衝突すれば自動で渡される　Script内で定義しなくても良い。


        if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
            GamePointText.text = string.Format("GainPoint: {0}", score);
        }

        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
            GamePointText.text = string.Format("GainPoint: {0}", score);
        }

        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 7;
            GamePointText.text = string.Format("GainPoint: {0}", score);
        }

        else if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 1;
            GamePointText.text = string.Format("GainPoint: {0}", score);
        }

        else
        {
            score += 0;
            GamePointText.text = string.Format("GainPoint: {0}", score);

        }

    }


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }



}
//Class