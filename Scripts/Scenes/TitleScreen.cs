using Godot;
using System;

public class TitleScreen : Node2D
{
	public Popup popUpMenu;

	public override void _Ready()
	{
		popUpMenu = (Popup)GetNode("SettingPopUp");
	}

	private void _on_StartButton_pressed()
	{
		GetTree().ChangeScene("res://Scenes/ScriptedScenes/MainGame.tscn");
	}


	private void _on_OptionsButton_pressed()
	{
		popUpMenu.Popup_();
	}


	private void _on_ExitPopupButton_pressed()
	{
		popUpMenu.Hide();
	}
}
