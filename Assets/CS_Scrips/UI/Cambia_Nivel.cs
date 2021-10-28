using UnityEngine.SceneManagement;
using UnityEngine;

public class Cambia_Nivel : MonoBehaviour
{
    [SerializeField]
    private string nivel; 

    public void Cambia_Escena()
    {
        SceneManager.LoadScene(nivel,LoadSceneMode.Single);
    }
}
