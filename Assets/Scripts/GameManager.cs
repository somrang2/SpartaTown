using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager의 인스턴스를 저장할 변수
    public static GameManager instance;
    public static bool player1;
    public static bool player2;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // 이미 다른 GameManager 인스턴스가 존재한다면, 이 인스턴스를 파괴
            Destroy(gameObject);
        }
    }
    

    public static void SetPlayerName(string playerName)
    {
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
        Debug.Log("Player name set to: " + playerName);
    }
}
