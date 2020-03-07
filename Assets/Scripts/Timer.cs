using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timeLabel;
    public Text dataLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int year = System.DateTime.Now.Year;
        int month = System.DateTime.Now.Month;
        int day = System.DateTime.Now.Day;
        int dayOfWeek = (int)System.DateTime.Now.DayOfWeek;
		int hour = System.DateTime.Now.Hour;
        int minute = System.DateTime.Now.Minute;
        int second = System.DateTime.Now.Second;
        timeLabel.text = string.Format("{0:D2}:{1:D2}", hour, minute);
        dataLabel.text = string.Format("{0} {1:D2} {2:D2} ", year, month, day);
        switch ( dayOfWeek ) {
            case 0: dataLabel.text += "SUN.";  break;
            case 1: dataLabel.text += "MON.";  break;
            case 2: dataLabel.text += "TUES.";  break;
            case 3: dataLabel.text += "WED.";  break;
            case 4: dataLabel.text += "THURS.";  break;
            case 5: dataLabel.text += "FRI.";  break;
            case 6: dataLabel.text += "SAT.";  break;
        }
    }
}
