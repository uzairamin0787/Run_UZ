using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offSet;
    void LateUpdate()
    {
        if(playerTransform != null)
        {
            transform.position = playerTransform.position+offSet;
        }
    }
}
