using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadGameScene()
    {
        // Affiche "Hello" dans la console
        Debug.Log("Hello");

        // Charge la scène "Game"
        SceneManager.LoadScene("Game");
    }
}
