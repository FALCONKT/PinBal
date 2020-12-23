﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour {

    //Global変数 定義
    Material myMaterial;

    //Emissionの最小値
    private float minEmission = 0.3f;

    //Emissionの強度
    private float magEmission = 0.2f;

    // 角度
    private int degree = 0;

    //発光速度
    private int speed = 10;

    //TargetのDefaultの色
    Color defaultColor = Color.white;


	// Use this for initialization
	void Start () {

        //Tagによって光らせる色を変える
        if (tag == "SmallStarTag") {
            this.defaultColor = Color.white;
        } else if (tag == "LargeStarTag") {
            this.defaultColor = Color.yellow;
        } else if (tag == "SmallCloudTag" || tag == "LargeCloudTag"){
            this.defaultColor = Color.cyan;
        }

        //ObjetにAtatchしているMaterialを取得　　定型
        this.myMaterial = GetComponent<Renderer>().material;

        //Objectの最初の色を設定
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);
    }

    // Update is called once per frame
    void Update()
    {

        if (this.degree >= 0)
        {
            // 光らせる強度を計算する
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);

            // エミッションに色を設定する
            myMaterial.SetColor("_EmissionColor", emissionColor);

            //現在の角度を小さくする
            this.degree -= this.speed;

        }
    }



        //衝突時に呼ばれる関数
        void OnCollisionEnter(Collision other)
        {
            //角度を180に設定
            this.degree = 180;
        }


}
//Class