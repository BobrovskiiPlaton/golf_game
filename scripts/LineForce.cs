using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineForce : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer;

    private void Update()
    {
        Vector2? worldPoint = CastMouseClickRay();

        if (!worldPoint.HasValue)
        {
            return;
        }
        
        DrawLine(worldPoint.Value);
    }

    private void DrawLine(Vector2 worldPoint)
    {
        Vector3[] positions = { transform.position, worldPoint };
        lineRenderer.SetPositions(positions);
        lineRenderer.enabled = true;
    }

    private Vector2? CastMouseClickRay()
    {
        Vector2 screenMousePos = Input.mousePosition;
        Vector2 worldMousePos = Camera.main.ScreenToWorldPoint(screenMousePos);
        RaycastHit2D hit = Physics2D.Raycast(worldMousePos, Vector2.zero);

        if (hit.collider != null)
        {
            return hit.point;
        }
        else
        {
            return null;
        }
    }
}