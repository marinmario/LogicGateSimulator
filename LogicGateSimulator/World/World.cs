using Godot;
using System;

public class World : Node2D
{
    public override void _Ready()
    {
        GetNode<Manager>("/root/Manager").world = this;
    }
}
