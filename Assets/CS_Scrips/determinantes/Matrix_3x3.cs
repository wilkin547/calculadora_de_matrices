using UnityEngine;
using UnityEngine.UI;

public class Matrix_3x3 : MonoBehaviour
{
 
    [SerializeField]
    public static int[] matriz = new int[9];

    public Text[] Texto_matrize = new Text[9];

    /* 
    * [ 0, 1 ,2
    *   3, 4 ,5
    *   6, 7 ,8
    *   0, 1 ,2
    *   3, 4 ,5]
    */
    public void Generar_Determinante()
    {
        var Dia_prin_1 = matriz[0] * matriz[4] * matriz[8];
        var Dia_prin_2 = matriz[3] * matriz[7] * matriz[2];
        var Dia_prin_3 = matriz[6] * matriz[1] * matriz[5];

        var Dia_Secun_1 = matriz[2] * matriz[4] * matriz[6];
        var Dia_Secun_2 = matriz[5] * matriz[7] * matriz[0];
        var Dia_Secun_3 = matriz[8] * matriz[1] * matriz[3];

        var Diagonal_principal = Dia_prin_1 + Dia_prin_2 + Dia_prin_3;
        var Diagonal_Secundaria = Dia_Secun_1 + Dia_Secun_2 + Dia_Secun_3;

        var determinante = Diagonal_principal - Diagonal_Secundaria;

        Calculate_Controller._Controller.Determinante(determinante);

        
    }
    public void reiniciar()
    {
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = 0;
            Texto_matrize[i].text = "0";
            Calculate_Controller._Controller.Resetear();
        }
    }
}
