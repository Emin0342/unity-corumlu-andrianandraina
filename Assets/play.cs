using UnityEngine;
using UnityEngine.SceneManagement;


public class play : MonoBehaviour
{
    public void Replaygame()
    {

        // Charge la scène "Game"
        SceneManager.LoadScene("Game");
    }
}
