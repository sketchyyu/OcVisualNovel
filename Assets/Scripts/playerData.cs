using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerData
{
    //Enum for selectable visions
    public enum visionType
    {
        BLANK,
        ANEMO,
        CRYO,
        DENDRO,
        ELECTRO,
        GEO,
        HYDRO,
        PYRO
    }

    //Player selected vision
    public visionType pVision;
    public string pName;

    #region Change UI Methods
    public void ChooseVision (visionType element)
    {
        pVision = element;
    }
    #endregion

}
