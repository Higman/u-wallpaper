using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class FloatObject : MonoBehaviour {

    public List<float> points = new List<float>();

    [SerializeField]
    private float _time;
    public float time {
        get { return _time; }
        set {
            if ( value <= 0 ) { _time = 0.01f; } else { _time = value; }
        }
    }

    float nowTime;
    Vector3 startPosition;
    Vector3 movedPosition;

    // Use this for initialization
    void Start () {
        init();  // スタート位置とゴール位置を設定
	}
	
	// Update is called once per frame
	void Update () {
        nowTime += Time.deltaTime;

        transform.position = Vector3.Lerp(startPosition, movedPosition, nowTime/_time);

        if ( nowTime > _time ) { init(); }
	}

    int prePointIndex = 0;  // ひとつ前の添え字

    void init() {
        int nextPointIndex;
        nowTime = 0;    // 初期化
        startPosition = movedPosition = transform.position;
        // 添え字が被らないように次の添え字を選択
        do {
            nextPointIndex = Random.Range(0, points.Count);
        } while ( nextPointIndex == prePointIndex );

        movedPosition.y = points[nextPointIndex];  
        prePointIndex = nextPointIndex;  // 更新
    }
}
