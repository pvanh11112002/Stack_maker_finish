using UnityEngine;

public abstract class BaseStateMachine : MonoBehaviour
{
    public abstract void Enter(GameManager gameManager);
    public abstract void Excute(GameManager gameManager);
    public abstract void OnCollisionEnter(Collision collision);
}
 