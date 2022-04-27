using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour
{
    public Grid grid = null;
    public Vector3Int cellPos;

    private void Awake()
    {
        grid = GetComponentInParent<Grid>();
    }

    void Update()
    {
        if (EditorApplication.isPlaying) return; // edit moe only
        if (!grid) return;

        cellPos = grid.WorldToCell(transform.position);
        transform.position = grid.CellToWorld(cellPos);
    }
}
