using Godot;
using System;
using System.Collections.Generic;

public partial class Character : CharacterBody2D
{
    [Export]
    protected int WalkSpeed = 1;

    [Export]
    protected int RunSpeed = 10;

    [Export]
    protected int Health = 100;

    private readonly List<Item> inventory = [];

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }
}
