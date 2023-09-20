using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public float colorChangeInterval = 2f;
    public float colorChangeSpeed = 0.2f;

    private Renderer prefabRenderer;
    private Color targetColor;
    private float timer = 0f;

    private void Start()
    {
        prefabRenderer = GetComponentInChildren<Renderer>();
        targetColor = prefabRenderer.material.color;
    }

    private void Update()
    {
        // Rotate the object around its local Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= colorChangeInterval)
        {
            // Change color every 'colorChangeInterval' seconds
            timer = 0f;
            targetColor = new Color(Random.value, Random.value, Random.value);
        }

        // Interpolate the color towards the target color
        prefabRenderer.material.color = Color.Lerp(prefabRenderer.material.color, targetColor, colorChangeSpeed * Time.deltaTime);
    }
}
