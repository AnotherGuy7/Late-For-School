using Godot;
using System;

public class OptionsButton : TextureButton
{
	public Popup popUpMenu;

	public override void _Ready()
	{
		popUpMenu = (Popup)GetNode("SettingPopUp");
	}
	public override void _Pressed()
	{
		popUpMenu.Popup_();
	}
}
