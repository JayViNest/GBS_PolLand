using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ObjectDrag : MonoBehaviour
{
    private Vector3 offset;

    private void OnMouseDown()
    {
        offset = transform.position - TileMapBuildScript.GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        Vector3 pos = TileMapBuildScript.GetMouseWorldPosition() + offset;
        transform.position = TileMapBuildScript.current.SnapCoordinateToGrid(pos);
        
    }
}
