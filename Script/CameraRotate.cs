using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

    private GameObject avatar;       //アバター格納用
    private GameObject L_eye;   //左目用
    private GameObject R_eye;   //右目用
    private GameObject background;  //背景Plane用
    private Vector3 EyeDirection;   //向いている方向

	// Use this for initialization
	void Start () {
        //unitychanをavatarに格納
        avatar = GameObject.Find("sample1");
        L_eye = GameObject.Find("J_Adj_L_FaceEye");
        R_eye = GameObject.Find("J_Adj_R_FaceEye");
        background = GameObject.Find("Plane");
	}

	// Update is called once per frame
    void Update () {
        //左シフトが押されている時
        if (Input.GetKey(KeyCode.Return))
        {
            //現在の視線方向を取得する
            EyeDirection = GameObject.Find("J_Bip_C_Head").transform.forward;
            //avatarからcamerafromavatarベクトル移動したところにカメラを置く。
            transform.position = (L_eye.transform.position + R_eye.transform.position)/2 + EyeDirection.normalized  ;
            //カメラを左目の方向に向かせる
            transform.LookAt(L_eye.transform.position);
        }
	}
}