using UnityEngine;
using UnityEngine.UI;

public class Agregar_Numeros : MonoBehaviour
{
    private string numero;

    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(agrega_numero_UI);
        numero = name[4].ToString();
    }

    private void Update()
    {
        if (Input.anyKey)  agrega_Numero_Input();  
    }

    public void agrega_numero_UI()
    {

        //le agregamos el valor

        //ya le usaremos
        if (!Calculate_Controller.calculate.Elemento_Actual().used)
        {
            //limpiamos el elemento
            Calculate_Controller.calculate.Elemento_Actual().Numero.text = "";
            Calculate_Controller.calculate.Elemento_Actual().used = true;
            Calculate_Controller.calculate.Celdas_activas++;

        }

        Calculate_Controller.calculate.Elemento_Actual().Numero.text += numero;

    }
    public void agrega_Numero_Input()
    {
        for (long numero = 0; numero < 10; numero++)
        {
            var String_numero = numero.ToString();
            if (Input.GetKeyDown(String_numero))
            {
                Calculate_Controller.calculate.Elemento_Actual().Numero.text += String_numero.Substring(0,1);
                break;
            }
        }


    }


}
