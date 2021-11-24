using UnityEngine;

public class Guia : MonoBehaviour
{

    private byte fila = 0;
    private byte Columna = 0;
    [SerializeField]
    private RectTransform transform;
    private elemento Ultimo_elemento = new elemento();
    



    public void Up()
    {
        fila -= 1;
        Calculate_Controller.calculate.Fila = fila;
        limite();
        Actualiza_posicion();
    }

    public void Down()
    {
        fila += 1;
        Calculate_Controller.calculate.Fila = fila;
        limite();
        Actualiza_posicion();
    }

    public void Rigth()
    {
        Columna += 1;
        Calculate_Controller.calculate.Columna = Columna;
        limite();
        Actualiza_posicion();

    }

    public void Left()
    {
        Columna -= 1;
        Calculate_Controller.calculate.Columna = Columna;
        limite();
        Actualiza_posicion();
      
    }

    private void limite()
    {
        fila = (byte)Mathf.Clamp(fila, 0, 3);
        Columna = (byte)Mathf.Clamp(Columna, 0, 3);
    }

    public void Actualiza_posicion()
    {
        //cada elemento tiene su posicion especial , llamada guia , asi puedo modificarlo facilmente   // :v , si es un lio 

        if (!Calculate_Controller.calculate.Elemento_Actual().used)
        {
            Ultimo_elemento.Is_Active = false;
        }
        else
        {
            Calculate_Controller.calculate.Elemento_Actual().Is_Active = true;
        }

        transform.position = Calculate_Controller.calculate.Elementos[fila, Columna].GetComponent<elemento>().guia.position;

        Ultimo_elemento = Calculate_Controller.calculate.Elemento_Actual(); 

        Calculate_Controller.calculate.Elemento_Actual().Is_Active = true;
    }
}
