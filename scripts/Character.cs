using Godot;
using System;

public partial class Character : CharacterBody2D
{
    [Export]
    protected int WalkSpeed = 1;

    [Export]
    protected int RunSpeed = 10;

    [Export]
    protected int Health = 100;
}
