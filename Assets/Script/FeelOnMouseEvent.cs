using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//システムにOnMouseEventと自分の名前を送り続ける
public class FeelOnMouseEvent : MonoBehaviour {
    void Start() {

    }

    void Update() {

    }

    //マウス侵入イベント
    public void OnMouseEnter() {
        Debug.Log(transform.name);
    }
    /*
    //マウス常駐イベント
    public void OnMouseOver() {
        Debug.Log("Over");
    }

    //マウス退散イベント
    public void OnMouseExit() {
        Debug.Log("Exit");
    }*/
}
