using UnityEngine;
using UnityEngine.UI;

public class Calculate_Controller : MonoBehaviour
{

    public static Calculate_Controller _Controller;
    [SerializeField]
    private bool _2x2;
    [SerializeField]
    private bool _3x3;
    [SerializeField]
    private bool IsNegative;
    private byte indice = 0;
    [SerializeField]
    private Text[] cantidades_2x2 = new Text[4];
    [SerializeField]
    private Text[] cantidades_3x3 = new Text[9];
    [SerializeField]
    private Text determinante;
    public int[] matrize = new int[9];


    private void Awake()
    {
        Calculate_Controller._Controller = this;
    }
    public void Determinante(int number)
    {
        determinante.text = number.ToString();
    }

    public void aumentar_Rango()
    {
        if (indice < 9)
        {
            indice++;
            IsNegative = false;
        }
    }

    public void Reducir_Rango()
    {
        if (indice >= 0)
        {
            indice--;
            IsNegative = false;
        }
    }

    public int GetPosicion()
    {
        return indice;
    }

    public int GetCurrentMatriz()
    {
        return matrize[indice];
    }
    /// <summary>
    /// Update the numbers  in the screen of de calculate
    /// </summary>
    public void Uptade_Numbers(int numero)
    {

        if (IsNegative) numero *= -1;
        if (_2x2)
        {
            if (indice < 4)
            {
                cantidades_2x2[indice].text = numero.ToString();
                matrize[indice] = numero;
            }
        }
        else if (_3x3)
        {
            if (indice < 9)
            {
                cantidades_3x3[indice].text = numero.ToString();
                matrize[indice] = numero;
            }
        }



    }
    public void Is_Negativo()
    {
        IsNegative = true;
    }

    /// <summary>
    /// devuelve todos los valores al inicio 
    /// </summary>
    public void Resetear()
    {
        indice = 0;
        determinante.text = "0";
        for (int i = 0; i <  matrize.Length; i++)
        {
            matrize[i] = 0;
            cantidades_2x2[i].text = "0";
            cantidades_3x3[i].text = "0";
        }
    }



}
