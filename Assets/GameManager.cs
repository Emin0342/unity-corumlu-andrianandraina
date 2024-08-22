using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float gameTime = 30f;  // Temps total pour le jeu
    public TextMeshProUGUI timerText;  // Référence au texte UI pour afficher le temps
    public GameObject defeatPanel;  // Panel affiché en cas de défaite
    public GameObject victoryPanel;  // Panel affiché en cas de victoire

    private int totalCollectibles;  // Nombre total d'objets à collecter
    private int collectedItems = 0;  // Nombre d'objets collectés

    void Start()
    {
        // Trouve tous les objets avec le tag "Collectible"
        totalCollectibles = GameObject.FindGameObjectsWithTag("Collectible").Length;

        // Initialise l'affichage du timer
        UpdateTimerUI();
        Time.timeScale = 1;  // Assure que le jeu se déroule à la vitesse normale
        defeatPanel.SetActive(false);  // Cache le panneau de défaite
        victoryPanel.SetActive(false);  // Cache le panneau de victoire
    }

    void Update()
    {
        if (gameTime > 0)
        {
            gameTime -= Time.deltaTime;  // Diminue le temps restant
            UpdateTimerUI();  // Met à jour le texte du timer

            if (gameTime <= 0)
            {
                GameOver(false);  // Si le temps est écoulé, déclenche la défaite
            }
        }
    }

    void UpdateTimerUI()
    {
        // Met à jour le texte du timer
        timerText.text = "Time: " + Mathf.Max(gameTime, 0).ToString("F0");
    }

    public void CollectItem()
    {
        collectedItems++;  // Incrémente le nombre d'objets collectés

        // Si tous les objets ont été collectés, déclenche la victoire
        if (collectedItems >= totalCollectibles)
        {
            GameOver(true);
        }
    }

    void GameOver(bool hasWon)
    {
        Time.timeScale = 0;  // Arrête le temps de jeu

        if (hasWon)
        {
            victoryPanel.SetActive(true);  // Affiche le panneau de victoire
        }
        else
        {
            defeatPanel.SetActive(true);  // Affiche le panneau de défaite
        }
    }

    public void Retry()
    {
        // Recharge la scène actuelle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()
    {
        // Charge la scène du menu (assurez-vous d'avoir une scène de menu avec un nom défini)
        SceneManager.LoadScene("MenuSceneName");
    }
}
