using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    private int _counter = 0;
    public int Score => _counter;
    [SerializeField]
    private AudioSource _audioSource;
    private void OnTriggerEnter(Collider boxCollider)
    {
        if (!boxCollider.CompareTag("Kupus")) return;

        _counter++;

        _audioSource.Play();

        Debug.Log($"Kupus count:{_counter}");
        Destroy(boxCollider.gameObject);
    }
}
