using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] 
    private Rigidbody _rb;
    [SerializeField]
    private Transform _playerTransform;


    [Header("Movement Params")]
    [SerializeField]
    Config _config;




    void Start()
    {
        _rb.linearVelocity = new Vector3(0,0, _config.Speed);
    }



    void OnLeft(InputValue value)
    {
        Dash(-1 * _config.Range);
    }

    void OnRight(InputValue value)
    {
        Dash(_config.Range);
    }

    private void Dash(int dashValue)
    {
        int targetX = (int)_playerTransform.position.x 
            + dashValue;

        if (targetX < -_config.Range || targetX > _config.Range)
            return;

        _playerTransform
            .Translate(new Vector3(dashValue,0,0));

    }
}
