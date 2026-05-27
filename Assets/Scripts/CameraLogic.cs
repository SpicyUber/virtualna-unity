using System;
using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    [SerializeField]
    private Transform _playerTransform;
    [SerializeField]
    private Vector3 _offset;

    void LateUpdate()
    {
        Vector3 playerPos
            = _playerTransform.position;

        playerPos.x = 0;

        transform.position
            = playerPos
            + _offset;

        Vector3 lookDir =
            playerPos
            - transform.position;

        lookDir.Normalize();

        transform.rotation =
            Quaternion.LookRotation(lookDir);
    }
}
