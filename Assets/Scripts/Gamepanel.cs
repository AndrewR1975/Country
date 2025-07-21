using UnityEngine;
using UnityEngine.UI;

public class Gamepanel : MonoBehaviour
{
    [SerializeField] private Settingpanel _settingpanel;
    [SerializeField] private Levelpanel _levelpanel;
    [SerializeField] private LearnPanel _learnpanel;
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _settingButton;
    [SerializeField] private Button _levelButton;
    [SerializeField] private Button _learnButton;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _settingButton.onClick.AddListener(HideScroll);
        _closeButton.onClick.AddListener(CloseScroll);
        _levelButton.onClick.AddListener(Level2);
        _learnButton.onClick.AddListener(Learn2);
    }
    private void Level2()
    {
        gameObject.SetActive(false);
        _levelpanel.gameObject.SetActive(true);

    }
    private void Learn2()
    {
        gameObject.SetActive(false);
        _learnpanel.gameObject.SetActive(true);

    }

    private void HideScroll()
    {
        gameObject.SetActive(false);
        _settingpanel.gameObject.SetActive(true);
    }
    private void CloseScroll()
    {
        gameObject.SetActive(false);
        _settingpanel.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
