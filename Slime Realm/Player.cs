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
		
		velocity.x = Input.GetActionStrength("ui_right")-Input.GetActionStrength("ui_left");
		velocity.y = Input.GetActionStrength("ui_down")-Input.GetActionStrength("ui_up");
		
		MoveAndSlide(velocity.Normalized()*Speed);
		
	}

}
