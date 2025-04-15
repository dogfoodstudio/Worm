using Godot;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public partial class Worm : Node3D
{
    // List to hold the children nodes
    private List<Node3D> children = new List<Node3D>();
    private List<Vector3> positions = new List<Vector3>();
    public override void _Ready()
    {
        children = new List<Node3D>();
        foreach (var child in GetChildren())
        {
            if (child is Node3D childNode)
            {
                children.Add(childNode);
                // Store the initial position of each child
                positions.Add(childNode.Position);
                Debug.Print(childNode.Name);
            }
        }

        for (int i = 0; i < children.Count; i++)
        {
            children[i].Position = new Vector3(i, 0, 0);
        }
    }

    public override void _Process(double delta)
    {
        if (children.Count == 0)
            return;
        var viewport = GetViewport();
        var camera = GetViewport().GetCamera3D();
        if (camera == null)
            return;
            

    }


}
