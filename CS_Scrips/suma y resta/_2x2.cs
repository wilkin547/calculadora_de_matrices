using UnityEngine;

public class _2x2 : MonoBehaviour
{

    public int[] matriz_Principal = new int[9];
    public int[] matriz_Secundaria = new int[9];
    public int[] matriz_Resultado = new int[9];

    public void suma_Matrize()
    {
        for (int indice = 0; indice < 9; indice++)
        {
            matriz_Resultado[indice] = matriz_Principal[indice] + matriz_Secundaria[indice];
        }
    }
}
