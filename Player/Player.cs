using Godot;
using System;

public class Player : KinematicBody2D
{
	const int moveSpeed = 500;
	const int jumpForce = -1000;
	const int gravity = 50;
	const int maxGravity = 1000;
	public float yVel = 0f;

	[Export(PropertyHint.Flags)]
	private bool cameraCurrent = false;

	public AnimatedSprite playerAnim;
	public Camera2D camera;

	public override void _Ready()
	{
		playerAnim = (AnimatedSprite)GetNode("PlayerAnimation");
		camera = (Camera2D)GetNode("PlayerCam");
	}

	public override void _PhysicsProcess(float delta)
	{
		Vector2 velocity = Vector2.Zero;
		if (Input.IsActionPressed("move_left"))
		{
			velocity.x -= moveSpeed;
			playerAnim.Play("walk");
			playerAnim.FlipH = true;
		}
		if (Input.IsActionPressed("move_right"))
		{
			velocity.x += moveSpeed;
			playerAnim.Play("walk");
			playerAnim.FlipH = false;
		}
		if (velocity.x == 0f)
		{
			playerAnim.Play("idle");
		}
		if (IsOnFloor())
		{
			if (Input.IsActionJustPressed("jump"))
			{
				yVel = jumpForce;
			}
		}
		if (!IsOnFloor())
		{
			if (yVel <= 0)
			{
				playerAnim.Play("jumping");
			}
			if (yVel > 0)
			{
				playerAnim.Play("falling");
			}
			if (yVel < maxGravity)
			{
				yVel += gravity;
			}
		}
		velocity.y = yVel;

		MoveAndSlide(velocity, new Vector2(0, -1));
	}
}
