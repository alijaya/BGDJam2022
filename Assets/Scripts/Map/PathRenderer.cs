using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

[RequireComponent(typeof(UILineRenderer))]
[ExecuteAlways]
public class PathRenderer : MonoBehaviour
{
    private UILineRenderer uiLineRenderer;

    [SerializeField] private MapNode firstNode;

    private void Awake()
    {
        uiLineRenderer = GetComponent<UILineRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Not the most efficient, but bodo amat buat gamejam
        DrawPath();
    }

    public void DrawPath()
    {
        if (firstNode)
        {
            List<Vector2> points = new List<Vector2>();
            populatePathPoints(firstNode, points);
            uiLineRenderer.Points = points.ToArray();
        }
    }

    void populatePathPoints(MapNode node, List<Vector2> points)
    {
        var firstPosition = node.GetComponent<RectTransform>().anchoredPosition;
        foreach (var nextNode in node.nextNode)
        {
            var secondPosition = nextNode.GetComponent<RectTransform>().anchoredPosition;
            points.Add(firstPosition);
            points.Add(secondPosition);
        }
        foreach (var nextNode in node.nextNode)
        {
            populatePathPoints(nextNode, points);
        }
    }
}
