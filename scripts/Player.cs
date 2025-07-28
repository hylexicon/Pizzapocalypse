using Godot;
using System;
using System.Linq;

public partial class Player : Character
{
	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		bool running = Input.IsActionPressed("run");
		int speed = running ? stats.RunSpeed : stats.WalkSpeed;
		Vector2 inputDirection = Input.GetVector("left", "right", "up", "down");
		Velocity = speed * inputDirection;

		MoveAndSlide();
	}

	public bool HasPizza()
	{
		return HasItem("Pizza");
	}

	public void RemovePizza()
	{
		Item pizza = inventory.FirstOrDefault(item => item.Name == "Pizza");
		RemoveItem(pizza);
	}
}
