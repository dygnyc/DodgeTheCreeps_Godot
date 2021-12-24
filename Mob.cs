using Godot;
using System;

public class Mob : RigidBody2D
{
    //
    [Export]
    public int minSpeed = 150;

    [Export]
    public int maxSpeed = 250;

    static private Random _random = new Random();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {//randomly choose an animation
        AnimatedSprite animSprite = GetNode<AnimatedSprite>("AnimatedSprite");
        string[] mobTypes = animSprite.Frames.GetAnimationNames();
        animSprite.Animation = mobTypes[_random.Next(0, mobTypes.Length)];
    }


    public void _on_VisibilityNotifier2D_screen_exited()
    {
        QueueFree();
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
