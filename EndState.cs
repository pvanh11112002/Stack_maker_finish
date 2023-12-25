using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndState : BaseStateMachine
{
    
    public override void Enter(GameManager gameManager)
    {
        Debug.Log("This is End State");
        LevelController.Instance.level++;
        
        gameManager.SwitchState(gameManager.StartS);
    }
    public override void Excute(GameManager gameManager)
    {
        
    }
    public override void OnCollisionEnter(Collision collision)
    {
        
    }
}
