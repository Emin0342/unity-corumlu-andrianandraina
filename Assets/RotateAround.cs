using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform centerObject;  // L'objet autour duquel tourner
    public float speed = 10.0f;     // Vitesse de rotation

    void Update()
    {
        // Rotation autour de l'objet central (la grande sphère)
        transform.RotateAround(centerObject.position, Vector3.up, speed * Time.deltaTime);
    }
}
