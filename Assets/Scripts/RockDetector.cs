using UnityEngine;

public class RockDetector : MonoBehaviour
{
    [SerializeField]
    private UIManager _uiManager;
    [SerializeField]
    private Rigidbody _rb;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Rock"))
            return;

        _uiManager.Show();

        _rb.linearVelocity = Vector3.zero;
    }
}
