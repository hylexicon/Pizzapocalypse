using Godot;
using System;

public partial class GameManager : Node
{
    private int money { get; set; } = 0;
    private int dough = 0;
    private int tomatoes = 0;
    private int cheese = 0;

    public void AddMoney(int amount)
    {
        money += amount;
    }
}
