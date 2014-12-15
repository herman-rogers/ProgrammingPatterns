using UnityEngine;
using System.Collections;

public class UnityObserverExample : UnityObserver
{
    public const string UPDATE_UNITYOBSERVER = "UPDATE_UNITYOBSERVER";
    public const string UPDATE_OBSERVER = "UPDATE_OBSERVER";
    public const string UPDATE_ALL_OBSERVERS = "UPDATE_ALL_OBSERVERS";
    private const float secondDelay = 3.0f;
    private ObserverExample normalObjectObserver;

    private void Start( )
    {
        normalObjectObserver = new ObserverExample( );
        StartCoroutine( UpdateObservers( ) );
    }

    public override void OnNotify( Object sender, EventArguments e )
    {
        switch ( e.eventMessage )
        { 
            case UPDATE_UNITYOBSERVER:
                Debug.Log( "UNITY OBSERVER UPDATE" );
                break;
            case UPDATE_ALL_OBSERVERS:
                Debug.Log( "UNITY OBSERVER ALL UPDATE" );
                break;
        }
    }

    private IEnumerator UpdateObservers( )
    {
        while ( true )
        {
            Subject.Notify( UPDATE_OBSERVER );
            yield return new WaitForSeconds( secondDelay );
            Subject.Notify( UPDATE_UNITYOBSERVER );
            yield return new WaitForSeconds( secondDelay );
            Subject.Notify( UPDATE_ALL_OBSERVERS );
            yield return new WaitForSeconds( secondDelay );
        }
    }
}
