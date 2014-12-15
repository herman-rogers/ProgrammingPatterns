using UnityEngine;
using System.Collections;

public class ObserverExample : Observer
{
    public override void OnNotify( Object sender, EventArguments e )
    {
        switch ( e.eventMessage ) 
        { 
            case UnityObserverExample.UPDATE_OBSERVER:
                Debug.Log( "OBSERVER UPDATE" );
                break;
            case UnityObserverExample.UPDATE_ALL_OBSERVERS:
                Debug.Log( "OBSERVER ALL UPDATE" );
                break;
        }
    }
}
