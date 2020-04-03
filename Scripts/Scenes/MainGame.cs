using Godot;
using System;

public class MainGame : Node2D
{
	public AnimationPlayer beginningAnim;
	public bool played = false;

	public override void _Ready()
	{
		beginningAnim = (AnimationPlayer)GetNode("BeginningTransition");
	}

	public override void _Process(float delta)
	{
		if (!played)
		{
			beginningAnim.Play("BeginningTransitionAnim");
			played = true;
		}
		base._Process(delta);
	}
}
