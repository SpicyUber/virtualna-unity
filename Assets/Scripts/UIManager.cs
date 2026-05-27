using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    ScoreTracker _scoreTracker;
    [SerializeField]
    TextMeshProUGUI _textMesh;
    [SerializeField]
    GameObject Panel;

    public void Show()
    {
        Panel.SetActive(true);
        _textMesh.text = "SCORE:" + _scoreTracker.Score;
    }
}
