using Godot;
using System;

public partial class PlayerScript : RigidBody2D
{
	[Export]
	private float _speed{get;set;} = 400;

	[Export]
	private AnimatedSprite2D _playerSprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	    var velocity = Vector2.Zero; // The player's movement vector.

    	if (Input.IsActionPressed("MoveRight"))
    	{
    	    velocity.X += 1;
    	}

    	if (Input.IsActionPressed("MoveLeft"))
    	{
    	    velocity.X -= 1;
    	}

    	if (Input.IsActionPressed("MoveDown"))
    	{
    	    velocity.Y += 1;
    	}

    	if (Input.IsActionPressed("MoveUp"))
    	{
    	    velocity.Y -= 1;
    	}

		if(velocity.Length() >0)
		{
			velocity = velocity.Normalized()*_speed;
			_playerSprite.Play("Moving");
			
			MoveAndCollide(velocity*(float)delta);
		}
		else
		{
			_playerSprite.Play("Idle");
		}		
	}
}
