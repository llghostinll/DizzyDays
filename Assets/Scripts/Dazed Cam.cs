using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class DazedCameraEffect : MonoBehaviour
{
    [Header("Dazed Effect Settings")]
    public float shakeIntensity = 0.9f;    // Intensity of shake
    public float shakeDuration = 0.5f;      // Duration of the shake
    public float rotationSpeed = 3f;        // Speed of rotation

    private Vector3 originalPosition;        // Original position of the camera
    private Quaternion originalRotation;     // Original rotation of the camera

    void Start()
    {
        originalPosition = transform.localPosition;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        // Apply a shaking effect
        Vector3 shakeOffset = new Vector3(
            Random.Range(-shakeIntensity, shakeIntensity),
            Random.Range(-shakeIntensity, shakeIntensity),
            0
        );

        // Apply a slight rotation to simulate dizziness
        float rotationOffset = Mathf.Sin(Time.time * rotationSpeed) * 1.5f; // Adjust amplitude as needed

        // Update the camera's position and rotation
        transform.localPosition = originalPosition + shakeOffset;
        transform.localRotation = originalRotation * Quaternion.Euler(0, 0, rotationOffset);
    }
}