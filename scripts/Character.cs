using Godot;
using Godot.Collections;
using System;

public partial class Character : CharacterBody2D
{
    [Export]
    protected Stats stats;

    [Export]
    protected Array<Item> inventory = [];

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }
}
