using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void BackToMenu()
    {

        // Charge la scène "Game"
        SceneManager.LoadScene("Menu");
    }
}
