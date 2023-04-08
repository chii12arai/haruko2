using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizz1 : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
 
        /* y軸を軸にして毎秒90度、回転させるQuaternionを作成（変数をrotとする）
        Quaternion rot = Quaternion.AngleAxis(90.0f*Time.deltaTime, Vector3.up);
        // 現在の自信の回転の情報を取得する。
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * rot;
        */

        transform.Rotate(0, 90 * Time.deltaTime, 0);

    }
}
