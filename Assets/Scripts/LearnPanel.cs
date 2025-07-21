using UnityEngine;
using UnityEngine.UI;

public class LearnPanel : MonoBehaviour

{
    [SerializeField] private Gamepanel _gamepanel;
    [SerializeField] private Button _closeButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        _closeButton.onClick.AddListener(CloseScroll);
    }

    private void CloseScroll()
    {
        gameObject.SetActive(false);
        _gamepanel.gameObject.SetActive(true);
    }
}
