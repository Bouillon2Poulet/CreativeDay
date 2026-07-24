using System.Collections.Generic;
using UnityEngine;

public class SceneBoundsDisplay : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;
    [ContextMenu("Update")]
    public void UpdateLineRenderer()
    {
        List<Vector3> positions = new List<Vector3>();
        for (int i = 0; i < transform.childCount; i++)
        {
            positions.Add(transform.GetChild(i).position);
        }
        lineRenderer.positionCount = positions.Count;
        lineRenderer.SetPositions(positions.ToArray());
    }
}
