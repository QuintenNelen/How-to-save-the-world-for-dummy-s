using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text ending;

    public void SetGameOver()
    {
        gameOverScreen.SetActive(true); //To show the UI screen
        //Debug.Log("screen");   //for debug
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void RestartGame()
    {
        //Debug.Log("restarted");
        SceneManager.LoadScene(3); //reload scene
    }
}
