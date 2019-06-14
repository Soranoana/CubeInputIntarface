using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//システムにOnMouseEventと自分の名前を送り続ける
public class FellOnMouseEvent : MonoBehaviour {
    void Start() {

    }

    void Update() {

    }

    //マウス侵入イベント
    public void OnMouseEnter1() {
        Debug.Log("Enter");
    }

    //マウス常駐イベント
    public void OnMouseOver1() {
        Debug.Log("Over");
    }

    //マウス退散イベント
    public void OnMouseExit1() {
        Debug.Log("Exit");
    }
}
