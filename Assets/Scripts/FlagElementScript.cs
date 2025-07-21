using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FlagElementScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _flagText;
    [SerializeField] private Image _flagImage;

    public void Init(string flagText, Sprite flagImage)
    {
        _flagText.text = flagText;
        _flagImage.sprite = flagImage;
    }
}
