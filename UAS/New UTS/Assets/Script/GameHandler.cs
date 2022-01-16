using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public Transform playerTransform;

    

    private void Start(){
        Debug.Log("GameHandler.Start");
        cameraFollow.Setup(() => playerTransform.position);
    }
}
