using UnityEngine;
using System.Collections;

public class levelMenu : MonoBehaviour {
    #region variablesPrimeraPantalla
    public string level1;
    public string level2;
    public string level3;
    public string level4;
    public string level5;
    public string level6;
    public string level7;
    public string level8;
    public string level9;
    public string level10;
    public string mainMenu;
    #endregion
    #region nivelesPrimeraPantalla
    public void nivel1()
    {
        


        Application.LoadLevel(level1);
        
    }
public void MenuPrincipal()
    {

        Application.LoadLevel(mainMenu);
    }
   
    public void nivel2()
    {

        Application.LoadLevel(level2);
    }
    public void nivel3()
    {

        Application.LoadLevel(level3);
    }
    public void nivel4()
    {

        Application.LoadLevel(level4);
    }
    public void nivel5()
    {

        Application.LoadLevel(level5);
    }
    public void nivel6()
    {

        Application.LoadLevel(level6);
    }
    public void nivel7()
    {

        Application.LoadLevel(level7);
    }
    public void nivel8()
    {

        Application.LoadLevel(level8);
    }
    public void nivel9()
    {

        Application.LoadLevel(level9);
    }
    public void nivel10()
    {

        Application.LoadLevel(level10);
    }

}
#endregion