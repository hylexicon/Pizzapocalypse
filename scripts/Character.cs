using Godot;
using Godot.Collections;
using System;
using System.Linq;

public partial class Character : CharacterBody2D
{
    [Export]
    protected Stats stats;

    [Export]
    protected Array<Item> inventory = [];

    public bool HasItem(string itemName)
    {
        return inventory.Any(item => item.Name == itemName);
    }

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }
}
