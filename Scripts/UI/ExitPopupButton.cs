using Godot;
using System;

public class ExitPopupButton : TextureButton
{
	public Popup popUpMenu;

	public override void _Ready()
	{
		popUpMenu = (Popup)GetNode("SettingPopUp");
	}
	public override void _Pressed()
	{
		popUpMenu.Hide();
	}
}
