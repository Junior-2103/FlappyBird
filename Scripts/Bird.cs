using Godot;
using System;

public partial class Bird : CharacterBody2D{
	
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	public override void _PhysicsProcess(double delta){
	
		Vector2 velocity = Velocity;

		if (!IsOnFloor()){
			velocity += GetGravity() * (float)delta;
		}

		if (Input.IsActionJustPressed("Jump")){
			velocity.Y = JumpVelocity;
		}
		
		velocity.X = Speed;
		
		Velocity = velocity;
		MoveAndSlide();
	}
}
