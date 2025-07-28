using Godot;
using System;

public partial class DeliveryZone : Area2D
{
	[Export]
	private int payment = 4;

	private GameManager gameManager;

	public override void _Ready()
	{
		gameManager = GetNode<GameManager>("%GameManager");
	}

	public void OnBodyEntered(Node2D body)
	{
		if (body is Player player && player.HasPizza())
		{
			player.RemovePizza();
			gameManager.AddMoney(payment);
			QueueFree();
		}
	}
}
