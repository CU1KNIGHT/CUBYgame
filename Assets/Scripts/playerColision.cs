
using UnityEngine;

public class playerColision : MonoBehaviour
{
    public movePlayer movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            GetComponent<movePlayer>().enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }

    }
}
