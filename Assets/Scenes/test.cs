using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
