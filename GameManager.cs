using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    BaseStateMachine currentState;
    public StartState StartS = new StartState();
    public PlayState PlayS = new PlayState();
    public PauseState PauseS = new PauseState();
    public EndState EndS = new EndState();
    // Start is called before the first frame update
    private void Awake()
    {   
        instance = this;
    }
    void Start()
    {
        currentState = StartS;
        StartS.Enter(this);
    }

    // Update is called once per frame
    void Update()
    {
        
        //currentState.Excute(this);   
    }
    public void SwitchState(BaseStateMachine state)
    {
        currentState = state;
        state.Enter(this);  
    }    
}
