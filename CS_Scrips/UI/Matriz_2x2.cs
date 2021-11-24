using UnityEngine;

public class Matriz_2x2 : MonoBehaviour
{
    public int n00, n01,
               n10, n11;

    private 
    int _determinante;

    public void Start()
    {
        int diagonal_principal = n00 * n11;
        int diagonal_Secudario = n01 * n10;
        _determinante = diagonal_principal - diagonal_Secudario;
    }

    public int[] transpuesta()
    {
        int[] nt = {n00 ,n10,
                    n01 ,n11};

        return nt;
    }

    public int determinante
    {
        get => _determinante;
    }

    private void agregar()
    {
        n00 = Calculate_Controller.calculate.celdas[0,0].Valor;
    }





}
