using Godot;
using System;

public partial class Stats : Resource
{
    [Export]
    public int WalkSpeed;

    [Export]
    public int RunSpeed;

    [Export]
    protected int Health;
}
