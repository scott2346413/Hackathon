using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progressiveDrawLine : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform point;

    Vector3[] points = new Vector3[5];

    float startX;

    private void Start()
    {
        startX = point.position.x;
    }

    private void Update()
    {
        Debug.Log(point.position.x);
        float pointProgress = (point.position.x - startX);
        Debug.Log(pointProgress);

        for (int pointNum = 0; pointNum < points.Length; pointNum++)
        {
            float pointPercent = pointNum / (points.Length - 1f);
            Debug.Log(pointPercent);
            points[pointNum].z = pointPercent * pointProgress;
            points[pointNum].x = -Mathf.Sin((points[pointNum].z / 3) * Mathf.PI) * 1.5f;
        }
        Debug.Log("----");

        lineRenderer.SetPositions(points);
    }
}
