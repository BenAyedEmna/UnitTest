using System;
using System.Collections.Generic;



int DeuxiemeGrandNombre(List<int> List)
{
    if (List == null)
    {
        throw new NullReferenceException("la liste ne doit pas etre null");
    }
    if (List.Count < 2)
    {
        throw new ArgumentOutOfRangeException("la longueur de la liste doit etre superieur a 2");
    }
    List.Sort();
    return List[1];
}


