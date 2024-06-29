using System.Collections.Generic;

// store all states in this script
enum PlayerStates
{
    idle,
    walk,
    run,
    grounded,
    jump,
    fall,
    death
}

// call states from the factory script
public class PlayerStateFactory
{
    PlayerStateMachine context;

    // store values in a dictionary instead of creating a new instance everytime this script is being called
    Dictionary<PlayerStates, PlayerBaseState> states = new Dictionary<PlayerStates, PlayerBaseState>();

    public PlayerStateFactory(PlayerStateMachine currentContext)
    {
        context = currentContext;
        states[PlayerStates.idle] = new PlayerIdleState(context, this);
        states[PlayerStates.walk] = new PlayerWalkState(context, this);
        states[PlayerStates.run] = new PlayerRunState(context, this);
        states[PlayerStates.jump] = new PlayerJumpState(context, this);
        states[PlayerStates.grounded] = new PlayerGroundedState(context, this);
        states[PlayerStates.fall] = new PlayerFallState(context, this);
        states[PlayerStates.death] = new PlayerDeathState(context, this);
    }

    public PlayerBaseState Idle()
    {
        return states[PlayerStates.idle];
    }

    public PlayerBaseState Walk()
    {
        return states[PlayerStates.walk];
    }

    public PlayerBaseState Run()
    {
        return states[PlayerStates.run];
    }

    public PlayerBaseState Jump()
    {
        return states[PlayerStates.jump];
    }

    public PlayerBaseState Grounded()
    {
        return states[PlayerStates.grounded];
    }
    public PlayerBaseState Fall()
    {
        return states[PlayerStates.fall];
    }
    public PlayerBaseState Death()
    {
        return states[PlayerStates.death];
    }
}
