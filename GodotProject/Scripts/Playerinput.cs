using Godot;
using System;

public partial class Playerinput : Node, IPlayerBehaviour
{
    [Export]
    public PlayerVariables _playerVariables { get;set; }

    public override void _Process(double delta)
        {
            var direction = Input.GetAxis("MoveLeft","MoveRight");
            if(Input.IsActionJustPressed("Jump") && _playerVariables.Grounded)
            {
                _playerVariables.Jump = true;
            }

            _playerVariables.XDirection = direction;
        }
}
