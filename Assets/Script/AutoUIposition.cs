//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class AutoUIposition : MonoBehaviour {

    private GameObject Canvas;
    private GameObject MiddleSide;
    private GameObject[] Num = new GameObject[9];
    private GameObject LeftText;
    private GameObject RightText;
    private GameObject UpText;
    private GameObject DownText;
    private GameObject[] NumText = new GameObject[9];
    private Vector2 CanvasResorution;
    private Vector2 NumPlatePercent = new Vector2(20, 20);
    private Vector2 MiddlePlatePercent = new Vector2(80, 80);

    void Start() {
        Canvas = GameObject.Find("Canvas");
        MiddleSide = GameObject.Find("MiddleSide");
        for (int i = 0; i < Num.Length; i++) {
            Num[i] = GameObject.Find(( i + 1 ).ToString());
            NumText[i] = GameObject.Find(( i + 1 ).ToString() + "Text");
        }
        LeftText = GameObject.Find("LeftText");
        RightText = GameObject.Find("RightText");
        UpText = GameObject.Find("UpText");
        DownText = GameObject.Find("DownText");

        /*
        gameObject.GetComponent<RectTransform>().offsetMin = new Vector2 (left,bottom);
        gameObject.GetComponent<RectTransform>().offsetMax = new Vector2 (right,top);
        var width  = self.GetComponent<RectTransform>().sizeDelta.x;
        var height = self.GetComponent<RectTransform>().sizeDelta.y;
        */

        CanvasResorution = Canvas.GetComponent<RectTransform>().sizeDelta;
        MiddleSide.GetComponent<RectTransform>().offsetMin = new Vector2(CanvasResorution.x * ( 100 - MiddlePlatePercent.x ) / 2 / 100, CanvasResorution.y * ( 100 - MiddlePlatePercent.y ) / 2 / 100);
        MiddleSide.GetComponent<RectTransform>().offsetMax = new Vector2(-CanvasResorution.x * ( 100 - MiddlePlatePercent.x ) / 2 / 100, -CanvasResorution.y * ( 100 - MiddlePlatePercent.y ) / 2 / 100);
        float Left = 0, Top = 0, Right = 0, Bottom = 0;
        for (int i = 0; i < Num.Length; i++) {
            if (i % 3 == 0) {
                Right = CanvasResorution.x * ( 50 + NumPlatePercent.x / 2 ) / 100;
                Left = CanvasResorution.x * ( 50 - NumPlatePercent.x * 3 / 2 ) / 100;
            } else if (i % 3 == 1) {
                Right = CanvasResorution.x * ( 50 - NumPlatePercent.x / 2 ) / 100;
                Left = CanvasResorution.x * ( 50 - NumPlatePercent.x / 2 ) / 100;
            } else if (i % 3 == 2) {
                Right = CanvasResorution.x * ( 50 - NumPlatePercent.x * 3 / 2 ) / 100;
                Left = CanvasResorution.x * ( 50 + NumPlatePercent.x / 2 ) / 100;
            }
            if (i / 3 == 0) {
                Bottom = CanvasResorution.y * ( 50 + NumPlatePercent.y / 2 ) / 100;
                Top = CanvasResorution.y * ( 50 - NumPlatePercent.y * 3 / 2 ) / 100;
            } else if (i / 3 == 1) {
                Bottom = CanvasResorution.y * ( 50 - NumPlatePercent.y / 2 ) / 100;
                Top = CanvasResorution.y * ( 50 - NumPlatePercent.y / 2 ) / 100;
            } else if (i / 3 == 2) {
                Bottom = CanvasResorution.y * ( 50 - NumPlatePercent.y * 3 / 2 ) / 100;
                Top = CanvasResorution.y * ( 50 + NumPlatePercent.y / 2 ) / 100;
            }
            Num[i].GetComponent<RectTransform>().offsetMin = new Vector2(Left, Bottom);
            Num[i].GetComponent<RectTransform>().offsetMax = new Vector2(-Right, -Top);
            NumText[i].GetComponent<RectTransform>().offsetMin = new Vector2(Left, Bottom);
            NumText[i].GetComponent<RectTransform>().offsetMax = new Vector2(-Right, -Top);
        }
        //左の一個だけ考えてすべて回転させて適用する
        Left = 0;
        Top = CanvasResorution.y * ( 100 - MiddlePlatePercent.y ) / 2 / 100;
        Right = CanvasResorution.x * ( 50 + MiddlePlatePercent.x / 2 ) / 100;
        Bottom = Top;
        LeftText.GetComponent<RectTransform>().offsetMin = new Vector2(Left, Bottom);
        LeftText.GetComponent<RectTransform>().offsetMax = new Vector2(-Right, -Top);
        RightText.GetComponent<RectTransform>().offsetMin = new Vector2(Right, Bottom);
        RightText.GetComponent<RectTransform>().offsetMax = new Vector2(-Left, -Top);
        //上の一個だけ考えてすべて回転させて適用する
        Left = CanvasResorution.x * ( 100 - MiddlePlatePercent.x ) / 2 / 100;
        Top = 0;
        Right = Left;
        Bottom = CanvasResorution.y * ( 50 + MiddlePlatePercent.y / 2 ) / 100;
        UpText.GetComponent<RectTransform>().offsetMin = new Vector2(Left, Bottom);
        UpText.GetComponent<RectTransform>().offsetMax = new Vector2(-Right, -Top);
        DownText.GetComponent<RectTransform>().offsetMin = new Vector2(Left, Top);
        DownText.GetComponent<RectTransform>().offsetMax = new Vector2(-Right, -Bottom);
    }
}
