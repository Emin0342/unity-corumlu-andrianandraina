using UnityEngine;

public class QuitterJeu : MonoBehaviour
{
    public void Quitter()
    {
        Debug.Log("Quitter le jeu");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
