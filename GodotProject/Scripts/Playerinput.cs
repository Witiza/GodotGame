using Godot;
using System;

public partial class Playerinput : PlayerBehaviour
{
    	public override void _Process(double delta)
        {
            var direction = Vector2.Zero;
            if(Input.IsActionPressed("MoveRight"))
            {
                direction.X+=1;
            }
            if(Input.IsActionPressed("ModeLeft"))
            {
                direction.X -=1;
            }

            if(Input.IsActionJustPressed("Jump") && _playerVariables.Grounded)
            {
                _playerVariables.Jump = true;
            }

            _playerVariables.PlayerDirection = direction;
        }
}
