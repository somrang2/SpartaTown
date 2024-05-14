using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager�� �ν��Ͻ��� ������ ����
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
            // �̹� �ٸ� GameManager �ν��Ͻ��� �����Ѵٸ�, �� �ν��Ͻ��� �ı�
            Destroy(gameObject);
        }
    }
    

    public static void SetPlayerName(string playerName)
    {
        PlayerPrefs.SetString("CurrentPlayerName", playerName);
        Debug.Log("Player name set to: " + playerName);
    }
}
