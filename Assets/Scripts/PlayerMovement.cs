using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _rb;
    [SerializeField]
    private int Speed;

     void Start()
    {
        _rb.linearVelocity = new Vector3(0,0, Speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Rock"))
            return;

        _rb.linearVelocity = Vector3.zero;
    }

}
