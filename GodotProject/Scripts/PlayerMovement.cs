using Godot;

public partial class PlayerMovement : CharacterBody2D, IPlayerBehaviour
{
    [Export]
    public PlayerVariables _playerVariables { get;set; }

    public override void _Process(double delta)
    {

    }

    public override void _PhysicsProcess(double delta)
    {
        var velocity = Velocity; 
        velocity = HandleXMovement(velocity, (float)delta);
        velocity = HandleYMovement(velocity, (float)delta);

        Velocity = velocity;

        MoveAndSlide();

        _playerVariables.Velocity = Velocity;
        _playerVariables.Grounded = IsOnFloor();
    }

    private Vector2 HandleXMovement(Vector2 velocity, float delta)
    {
        velocity.X = _playerVariables.XDirection*_playerVariables.Speed*delta;

        return velocity;
    }

        private Vector2 HandleYMovement(Vector2 velocity, float delta)
    {
        velocity.Y +=_playerVariables.Gravity*delta;

        if(_playerVariables.Jump)
        {
            _playerVariables.Jump = false;
            velocity.Y = _playerVariables.JumpImpulse;
        }

        return velocity;
    }
}
