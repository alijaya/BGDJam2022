using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private Dictionary<string, MapNode> mapNodes = new Dictionary<string, MapNode>();

    private void Awake()
    {
        mapNodes.Clear();
        var mapNodeList = FindObjectsOfType<MapNode>();

        foreach (var mapNode in mapNodeList)
        {
            mapNodes.Add(mapNode.name, mapNode);
        }

        CheckWin();
    }

    private void Start()
    {
        UpdateDisplay();
    }

    public void CheckWin()
    {
        // check if winning
        var mapPaths = GlobalRef.instance.mapPaths;
        if (mapPaths.Count > 0)
        {
            var currentNodeName = mapPaths[mapPaths.Count - 1];
            // win if current node doesn't have any next node
            if (mapNodes.TryGetValue(currentNodeName, out var node))
            {
                if (node.nextNode.Count == 0)
                {
                    // Win!
                    GlobalRef.instance.GoToEnding();
                }
            }
        }
    }

    public void UpdateDisplay()
    {
        var paths = GlobalRef.instance.mapPaths;
        if (paths.Count > 0) // if there's at least one visited node
        {
            // set all node to unreachable
            foreach (var mapNode in mapNodes.Values)
            {
                mapNode.nodeState = MapNode.NodeState.Unreachable;
            }

            // set path
            foreach (var nodeName in paths)
            {
                if (mapNodes.TryGetValue(nodeName, out var node))
                {
                    node.nodeState = MapNode.NodeState.Done;
                }
            }

            // set reachable node
            if (mapNodes.TryGetValue(paths[paths.Count - 1], out var lastNode))
            {
                foreach (var nextNode in lastNode.nextNode)
                {
                    nextNode.nodeState = MapNode.NodeState.Reachable;
                }
            }
        }
        else // no visited node, we begin the game
        {
            // set all node to reachable
            foreach (var mapNode in mapNodes.Values)
            {
                mapNode.nodeState = MapNode.NodeState.Reachable;
            }

            // if there's incoming edge, set to Unreachable
            foreach (var mapNode in mapNodes.Values)
            {
               foreach (var nextNode in mapNode.nextNode)
                {
                    nextNode.nodeState = MapNode.NodeState.Unreachable;
                }
            }
        }

        // update all
        foreach (var mapNode in mapNodes.Values)
        {
            mapNode.UpdateDisplay();
        }
    }
}
