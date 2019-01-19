using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoResizeGridElement : MonoBehaviour {

    private Canvas canvas;
    private GridLayoutGroup gridLayout;

    private void Start()
    {
        canvas = this.GetComponentInParent<Canvas>();
        gridLayout = this.GetComponent<GridLayoutGroup>();
    }

    private void Update()
    {
        AutoResize();
    }

    private void AutoResize()
    {
        float cellX = canvas.pixelRect.width * 0.1916f;
        float cellY = canvas.pixelRect.height * 0.82f / 3;
        gridLayout.cellSize = new Vector2(cellX, cellY);
    }
}