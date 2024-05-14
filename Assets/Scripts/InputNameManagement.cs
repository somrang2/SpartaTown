using UnityEngine;
using UnityEngine.UI;

public class InputNameManagement : MonoBehaviour
{
    public InputField playerNameInput;

    private PlayButton playButton;

    private string playerName = null;

    public bool CorrectInput = false;

    private void Awake()
    {
        playButton = FindObjectOfType<PlayButton>(); // PlayButton 컴포넌트를 찾아 할당
    }

    private void Update()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
        if (playerName.Length <= 10 && playerName.Length >= 2 && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("wewewew");
            CorrectInput = true;
            InputName();
            playButton.StartGame();
        }
        if (playerName.Length <= 10 && playerName.Length >= 2)
        {
            CorrectInput = true;
            InputName();
        }
    }


    public void InputName()
    {
        playerName = playerNameInput.text;
        GameManager.SetPlayerName(playerName);
    }
}
