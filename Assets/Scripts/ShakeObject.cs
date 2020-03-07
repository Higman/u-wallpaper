using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeObject : MonoBehaviour {

    public float dRotateMax, dRotateMin;
    public float time;

    float nowTime;
    Quaternion preQua;  
    Quaternion nxtQua;  
    Quaternion fstQua;  

    void Start() {
        //- 初期化
        nowTime = time+1; 
        fstQua = transform.rotation;        // 初期角度の保存
    }
	
	// Update is called once per frame
	void Update () {
        if ( nowTime > time ) {
            nowTime = 0;  // 初期化
            preQua = transform.rotation;    // 旧角度の更新
            // 次角度の決定
            nxtQua = fstQua;                
            nxtQua *= Quaternion.Euler(new Vector3(Random.RandomRange(dRotateMin, dRotateMax), 0, 0));
            nxtQua *= Quaternion.Euler(new Vector3(0, Random.RandomRange(dRotateMin, dRotateMax), 0));
        }

        transform.rotation = Quaternion.Slerp(preQua, nxtQua, nowTime/time);    // 

        nowTime += Time.deltaTime;  // 更新
    }
}
