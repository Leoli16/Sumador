using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sumador : MonoBehaviour
{
    public TMP_InputField num1;
    public TMP_InputField num2;
    public TextMeshProUGUI resultado;
    
    public void sumar()
    {
        int numero1 = int.Parse(num1.text);
        int numero2 = int.Parse(num2.text);
        resultado.text = (numero1 + numero2).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
