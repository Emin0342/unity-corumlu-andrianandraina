using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectionCredits : MonoBehaviour
{
    public void RedirectSceneCredit()
    {

        SceneManager.LoadScene("Credit");
    }
}
