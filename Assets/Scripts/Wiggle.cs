using UnityEngine;

public class Wiggle : MonoBehaviour
{
    [SerializeField]
    [Range(0,10f)]
    private float _range;
    void Update()
    {
        float y = Mathf.Sin(Time.timeSinceLevelLoad);

        transform.localPosition = new Vector3(0,_range * y,0);
    }
}
