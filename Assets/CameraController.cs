using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 10.0f; // Vitesse de déplacement
    public float sensitivity = 100.0f; // Sensibilité de la souris

    private float rotationY = 0.0f;
    private float rotationX = 0.0f;

    void Start()
    {
        // Verrouille le curseur au centre de l'écran
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Vous pouvez modifier la sensibilité ici si nécessaire
        sensitivity = 150.0f; // Exemple de changement de sensibilité

        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Le reste du code reste inchangé
        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f);
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);

        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        transform.position += move;
    }

}
