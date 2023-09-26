using Godot;
using System;

public enum PlayerStates
{
    IDLE,
    MOVING,
    JUMPING,
    FALLING
}

public abstract class PlayerState 
{
    protected bool _looping;
    protected float _speed;
    protected string _animationString;
    
    public PlayerState(bool looping, float speed, string animationString)
    {
        _looping = looping;
        _speed = speed;
        _animationString = animationString;
    }

    public string GetAnimationString() => _animationString;
    public virtual void UpdateState(){}
}

public class IdleState : PlayerState
{
    public IdleState(bool looping, float speed, string animationString) : base(looping, speed, animationString)
    {

    }
}

