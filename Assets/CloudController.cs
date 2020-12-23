using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

    //最小Size
    //private float minimum = 0.1f;
    private float minimum = 1.25f;

    //拡大縮小Speed
    //private float magSpeed = 10.0f;
    private float magSpeed = 3.0f;


    //拡大率
    //private float magnification = 0.07f;
    private float magnification = 0.2f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //雲を拡大縮小
        //それぞれの軸方向の拡大率を指定

        this.transform.localScale =
        new Vector3(
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification,
            this.transform.localScale.y,
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification
        );

        //「Vector」は、オブジェクトの座標やオブジェクトに加わる力の方向などを扱う型
        //Vector2はfloat型のx, yの要素
        //Vector3はfloat型のx, y, zの要素
        // 第一引数にX軸方向、第二引数にY軸方向、第三引数にZ軸方向の値
        //yだけ回転するので　yは引数のみ指定

        //Time.time　はGame開始から何秒経ったか
    }
}
