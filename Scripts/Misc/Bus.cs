using Godot;
using System;

public class Bus : RigidBody2D
{
	public float constantVelX = 50f;
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(float delta)
	{
		MoveLocalX(constantVelX * delta);
	}
}
