using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    // Vitesse de rotation en degrés par seconde
    public float rotationSpeed = 100f;

    // Update est appelée une fois par frame
    void Update()
    {
        // Faire tourner le GameObject autour de l'axe Y
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
