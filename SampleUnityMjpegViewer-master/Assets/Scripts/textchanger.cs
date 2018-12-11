using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textchanger : MonoBehaviour
{
    public void OnClickButton()
    {
        // Textコンポーネント郡を取得します。
        var components = this.gameObject.GetComponentsInChildren<Text>();
        // テキストを文字の状態によって変更するようにします。
        components[0].text = components[0].text == "Button" ? "Changed" : "Button";
    }
}
