using System;
using System.Collections.Generic;


public class TuDoisMettreTesFonctionDansUneClass
{
    public static int DeuxiemeGrandNombre(List<int> List)
    {
        if (List == null)
        {
            throw new NullReferenceException("la liste ne doit pas etre null");
        }
        if (List.Count < 2)
        {
            throw new ArgumentOutOfRangeException("la longueur de la liste doit etre superieur a 2");
        }
        int i,max1,max2; 
        if(List[0]>List[1])
        {
            max1 = List[0];
            max2 = List[1]; 
        }
        else
        {
            max1 = List[1];
            max2 = List[0];

        }
        for(i=2;i<List.Count;i++)
        {
            if(List[i]>max1)
            {
                max2 = max1; 
                max1 = List[i]; 
            }
            if((List[i]>max2) && (List[i]<max1))
            {
                max2 = List[i]; 
            }
        }
        return max2;
    }
}


