using Godot;
using System;
using System.ComponentModel;

public partial class Main : Control
{
	[Export] private UiButton _playButton;
	[Export] private UiButton _quitButton;

 	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{        
        GetTree().Paused = false;
		_playButton.Pressed += () => { GameManager.LoadGameScene(); };
		_quitButton.Pressed += () => { GetTree().Quit(); };  
	}
}
