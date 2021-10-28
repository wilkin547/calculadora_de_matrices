using UnityEngine;

public class Matrix_2x2 : MonoBehaviour
{

    
    public void Genera_determinante()
    {
        var diagonal_Principal = Calculate_Controller._Controller.matrize[0] * Calculate_Controller._Controller.matrize[3];
        var diagonal_Secundaria = Calculate_Controller._Controller.matrize[1] * Calculate_Controller._Controller.matrize[2];

        var determinante = diagonal_Principal - diagonal_Secundaria;

        Calculate_Controller._Controller.Determinante(determinante);
    }

}
