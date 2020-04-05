using Godot;
using System;

public class MainGame : Node2D
{
	public AnimationPlayer beginningAnim;
	public Camera activeCam;

	public override void _Ready()
	{
		beginningAnim = (AnimationPlayer)GetNode("BeginningTransition");
		beginningAnim.Play("BeginningTransitionAnim");
	}

	/*public override void _Process(float delta)
	{
		base._Process(delta);
	}*/

	private void _on_BeginningTransition_animation_finished(String anim_name)
	{
		Player.player.camera.MakeCurrent();
	}
}
