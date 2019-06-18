using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//OnMouseイベントをもらって適切に処理する
public class InterfaceSystem : MonoBehaviour {

    private int stage;//入力フラグ
    /* stage place
     * 0     原点　no5
     * 1     数字　no1,2,3,4,6,7,8,9
     * 2     切り替えエリア　middle
     * 3     Error
     */
    private int place;//今いる場所
    private string character;//入力文字
    public string[,,] stringSet = new string[3, 8, 5] { { {"a","b","c","d","e"},{"f","g","h","i","j"},{"k","l","m","n","o"},{"p","q","r","s","t"},{"u","v","w","x","y"}, {"z","'",".",",","_"},  {"↵\n","↵\n","↵\n","↵\n","↵\n"},{"Error","Error","Error","Error","Error"} },
                                                        { {"A","B","C","D","E"},{"F","G","H","I","J"},{"K","L","M","N","O"},{"P","Q","R","S","T"},{"U","V","W","X","Y"}, {"Z","!","?","(",")"},  {"↵\n","↵\n","↵\n","↵\n","↵\n"},{"Error","Error","Error","Error","Error"} },
                                                        { {"1","2","3","4","5"},{"6","7","8","9","0"},{"+","-","*","/","."},{"@","#","$","%","&"},{"=","~","^","|","\\"},{";","{","}","`","\""}, {":","[","]","<",">"},          {"↵\n","↵\n","↵\n","↵\n","↵\n"}           } };

    void Start() {
        
    }

    void Update() {

    }
}
