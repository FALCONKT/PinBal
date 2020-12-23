using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {


    //回転速度

    //private float rotSpeed = 1.75f;

    private float rotSpeed = 1.0f;
    //private float rotSpeed = 0.1f;


    // Use this for initialization
    void Start () {

        //回転を開始する角度を設定
        this.transform.Rotate(0,Random.Range(0,360), 0);

		
	}
	
	// Update is called once per frame
	void Update () {

        //回転する方向を決める
        this.transform.Rotate(0, this.rotSpeed, 0);


	}
}
