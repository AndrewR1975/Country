using UnityEngine;
using UnityEngine.UI;

public class Settingpanel : MonoBehaviour
{
    [SerializeField] private Gamepanel _gamepanel;
    [SerializeField] private Languagepanel _languagepanel;
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _languageButton;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _languageButton.onClick.AddListener(HideScroll);
        _closeButton.onClick.AddListener(CloseScroll);
    }
    private void HideScroll()
    {
        gameObject.SetActive(false);
        _languagepanel.gameObject.SetActive(true);
    }
    private void CloseScroll()
    {
        gameObject.SetActive(false);
        _gamepanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
