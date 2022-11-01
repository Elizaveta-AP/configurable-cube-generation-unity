using UnityEngine;
using System.Globalization;
using TMPro;
using UnityEngine.UI;

public class InputFields : MonoBehaviour
{
    public TMP_InputField _frequency, _speed, _distance;
    private void Start()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
    }

    private float ConvertStringToFloat(string value, TMP_InputField parametrName)
    {
        float floatValue = float.Parse(value);
        if (floatValue < 0) 
        {
            floatValue = 0;
            parametrName.text = "0";
        }
        return floatValue;
    }
    
    public void InputFrequency(string value)
    {
        CubesGenerator.GenerationFrequency = ConvertStringToFloat(value, _frequency);
    }
   
    public void InputSpeed(string value)
    {
        CubeController.Speed = ConvertStringToFloat(value, _speed);
    }
   
    public void InputDistancce(string value)
    {
        CubeController.Distance = ConvertStringToFloat(value, _distance);
    }
}
