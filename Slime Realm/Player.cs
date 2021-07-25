using Godot;
using System;

public class Player : KinematicBody2D
{
	
	[Export]
	public int Speed = 400;
	
	public override void _Ready()
	{
		
		var animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
		animationPlayer.Play("Idle");
		
	}
	
	public override void _PhysicsProcess(float delta)
	{
		
		var velocity = new Vector2();
		
		velocity.x = (Input.GetActionStrength("ui_right")-Input.GetActionStrength("ui_left"))*Speed;
		velocity.y = 80;
		
		if (Input.IsActionJustPressed("ui_up"))
		{
			velocity.y = -16000;
		}
		
		MoveAndSlide(velocity);
		
	}

}
