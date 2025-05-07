using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class divididor : MonoBehaviour
{
    public TMP_InputField num1;
    public TMP_InputField num2;
    public TextMeshProUGUI resultado;
    
    public void dividir()
    {
        int numero1 = int.Parse(num1.text);
        int numero2 = int.Parse(num2.text);
        if (numero2 != 0)
        {
            resultado.text = (numero1 / numero2).ToString();
        }
        else
        {
            resultado.text = "¡No se puede dividir por 0!";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
