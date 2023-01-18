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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        SceneManager.LoadScene(5); //reload scene
=======
        SceneManager.LoadScene(2); //reload scene
>>>>>>> 86854edd2d0f1e03e7e610f70784ef4ac0d05e31
=======
        SceneManager.LoadScene(2); //reload scene
>>>>>>> 86854edd2d0f1e03e7e610f70784ef4ac0d05e31
=======
        SceneManager.LoadScene(2); //reload scene
>>>>>>> 86854edd2d0f1e03e7e610f70784ef4ac0d05e31
    }
}
