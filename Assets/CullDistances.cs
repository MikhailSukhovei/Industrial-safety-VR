using UnityEngine;
using System.Collections;

public class CullDistances : MonoBehaviour
{
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        float[] distances = new float[32];
        distances[8] = 25;
        camera.layerCullDistances = distances;
    }
}