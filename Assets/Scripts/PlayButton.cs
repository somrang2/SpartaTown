using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public InputNameManagement inputNameManagement;

    private void Awake()
    {
        inputNameManagement = FindObjectOfType<InputNameManagement>(); 
    }

    public void StartGame()
    {
        if (inputNameManagement.CorrectInput == true)
        {
            SceneManager.LoadScene("MainScene"); 
        }
    }
}
