
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManger gameManger;
     void OnTriggerEnter()
    {
        gameManger.CompleteLevel();

    }
}
