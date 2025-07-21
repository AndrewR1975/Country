using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor.Rendering;

namespace Assets.Scripts
{
    public class Country2:MonoBehaviour
    {
        public String CountryName { get; set; }
        // public Image 
        public void  SetNameCounry(string _name)
        { 
            CountryName = _name;
        }
    }

}
