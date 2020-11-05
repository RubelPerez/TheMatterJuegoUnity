using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

    public string menuNivel;
    public string acercaDe;
   public void MenuNivel() {
        Application.LoadLevel(menuNivel);

    }

   public void AcercaDe() {

        Application.LoadLevel(acercaDe);
    }
    public void Salir()
    {

        Application.Quit();
    }
}