using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public GameObject panel;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player1Select;
    public GameObject Player2Select;


    public void ClickCharacter()
    {
        panel.SetActive(true);
        Player1Select.SetActive(true);
        Player2Select.SetActive(true);
        Player1.SetActive(false);
        Player2.SetActive(false);
    }

    public void SelectPlayer1()
    {
        panel.SetActive(false);
        Player1Select.SetActive(false);
        Player2Select.SetActive(false);
        Player1.SetActive(true);
        Player2.SetActive(false);
        GameManager.Getplayer1(Player1);
    }

    public void SelectPlayer2()
    {
        panel.SetActive(false);
        Player1Select.SetActive(false);
        Player2Select.SetActive(false);
        Player1.SetActive(false);
        Player2.SetActive(true);
        GameManager.Getplayer2(Player2);
    }

}
