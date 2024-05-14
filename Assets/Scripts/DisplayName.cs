using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text nameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("CurrentPlayerName");
        nameText.text = playerName;
    }

}
