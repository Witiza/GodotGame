using Godot;
using System;
using System.Collections.Generic;


public partial class PlayerVariables : Node
{
	[Export]
	public float Speed{get;set;}
	[Export]
	public float JumpImpulse{get;set;}
	[Export]
	public float Gravity{get;set;}

	public Vector2 Velocity{get;set;}
	public bool Grounded{get;set;}
	public float XDirection{get;set;}
	public bool Jump{get;set;}

}
