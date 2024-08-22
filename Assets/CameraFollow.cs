using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // La cible que la caméra doit suivre
    public Vector3 offset; // La différence de position entre la caméra et le joueur

    void Start()
    {
        // Optionnel : initialiser l'offset si ce n'est pas fait dans l'Inspector
        if (offset == Vector3.zero)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        // Met à jour la position de la caméra
        transform.position = player.position + offset;
    }
}
