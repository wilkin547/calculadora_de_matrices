using UnityEngine;


public class sistema_Touch : MonoBehaviour
{
    private Vector2 inicio;
    private Vector2 final;
    private Touch Mi_Touche;

    private int Fila;
    private int Columna;

    private float diferencia_X;
    private float diferencia_Y;

    public Guia guia;


    void Update()
    {
        if (Input.touchCount > 0)
        {
            Mi_Touche = Input.GetTouch(0);

            inicio = Mi_Touche.phase == TouchPhase.Began ? Mi_Touche.position : inicio;

            final = Mi_Touche.phase == TouchPhase.Ended ? Mi_Touche.position : final;


            //1 == mayor a 0 , 2 menor a 0
            Fila = inicio.y < final.y ? 1 : 2;
            Columna = inicio.x < final.x ? 1 : 2;

            if (Mi_Touche.phase == TouchPhase.Ended)
            {

                diferencia_Y = Fila == 1 ? final.y - inicio.y : inicio.y - final.y;
                diferencia_X = Columna == 1 ? final.x - inicio.x : inicio.x - final.x;


                if (diferencia_X >= diferencia_Y)
                {
                    if (diferencia_X >= 50)
                    {
                        if (Fila == 1) guia.Rigth();
                        else guia.Left();

                        print("se movio arriba o abajo");
                    }
                    else
                    {
                        print("no se cumplio con la diferencia de 300");
                    }



                }
                else if (diferencia_X <= diferencia_Y)
                {

                    if (diferencia_Y >= 50)
                    {
                        if (Columna == 1) guia.Up();
                        else guia.Down();
                        print("se movio de izquiera ");
                    }
                    print("no se cumplio con la diferencia de 50");


                }


            }


        }



    }

}

