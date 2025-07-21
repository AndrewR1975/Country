using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Flagcountry : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Image ImageCountry;
    [SerializeField] TextMeshProUGUI NameCountry;

    private void Start()
    {
        setCountry(2);
    }

    public void setCountry(int _country)
    {
        Country enumValue = (Country)_country;
        NameCountry.text = enumValue.ToString();
        //загрузить картинку флага по индексу
        Sprite result = Resources.Load<Sprite>($"{_country + 2}");
        ImageCountry.sprite = result;

        Country[] values = (Country[])Enum.GetValues(typeof(Country));

    }
    public enum Country
    {
        USA,
        Russia,
        China,
        France,
        Germany,
        Japan,
        Poland,
        Great_Britan,

    }

}
