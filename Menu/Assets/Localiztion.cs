using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localiztion : MonoBehaviour {

    // Use this for initialization
    public Dropdown dropDown;
    public Sprite[] modes;
    private void Start()
    {
        dropDown.ClearOptions();

        List<Dropdown.OptionData> menuItems = new List<Dropdown.OptionData>();

        foreach(var mode in modes)
        {
            var modeOptions = new Dropdown.OptionData(mode.name, mode);
            menuItems.Add(modeOptions);
        }

        dropDown.AddOptions(menuItems);
    }
}
