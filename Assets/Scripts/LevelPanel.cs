using UnityEngine;
using UnityEngine.UI;

public class Levelpanel : MonoBehaviour
{
    [SerializeField] private Gamepanel _gamegpanel;
    [SerializeField] private Button _closeButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        _closeButton.onClick.AddListener(CloseScroll);
    }
   
    private void CloseScroll()
    {
        gameObject.SetActive(false);
        _gamegpanel.gameObject.SetActive(true);
    }
}