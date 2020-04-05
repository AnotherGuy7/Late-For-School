using Godot;
using System;

public class Bus : RigidBody2D
{
	public float constantVelX = 250f;

	public override void _PhysicsProcess(float delta)
	{
		MoveLocalX(constantVelX * delta);
	}
}
