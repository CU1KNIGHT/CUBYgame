
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform player ;
    public Vector3 offset;

    // Update is called once per frame
    void Start()
    {
        //player = GetComponent<Transform>();// instance of function
                                     
    }

    void Update()
    {
       // Debug.Log(player.position);
        transform.position = player.position+offset;
    }
}
