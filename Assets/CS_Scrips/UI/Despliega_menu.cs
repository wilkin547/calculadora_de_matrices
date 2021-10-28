using UnityEngine;

public class Despliega_menu : MonoBehaviour
{
    [SerializeField]
    private GameObject Boton;
    private bool IS_Desplegado;

    public void Desplegar()
    {
        gameObject.SetActive(false);
        Boton.SetActive(true);
    }
}
