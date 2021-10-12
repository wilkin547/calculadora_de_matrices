using UnityEngine;

public class agrega_numero : MonoBehaviour
{
    [SerializeField]
    private int numero;

    public void Agrega()
    {
        Calculate_Controller._Controller.Uptade_Numbers(numero);
        Calculate_Controller._Controller.aumentar_Rango();
        print("se agrego el numero" + numero);
    }

}
