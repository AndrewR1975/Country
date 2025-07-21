using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using Assets.Scripts;
using System.IO;
public class Languagepanel : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private Settingpanel _settingpanel;
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private Country2 _country;
    private Flagcountry[] Country; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _closeButton.onClick.AddListener(Hidescroll);
        GetCountry();
        //_settingpanel.gameObject.GetComponent  
    }
    private void Hidescroll()
    {
        gameObject.SetActive(false);
        _settingpanel.gameObject.SetActive(true);
    }

    private void GetCountry()
    {
      DirectoryInfo dir = new DirectoryInfo("Assets/flags");
      FileInfo[] infos = dir.GetFiles("*.*");
        foreach (FileInfo f in infos) 
        {
            Debug.Log(f.Name);
        }
            //var x = Country2.Instantiate(_country, transform);
            //x.SetNameCounry("asd");
        
    }


    // Update is called once per frame
}
