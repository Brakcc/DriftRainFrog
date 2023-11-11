using UnityEngine;
using Cinemachine;

public interface ICameraManager
{
    public void OnZoomFight(Unit unit, CinemachineVirtualCamera cam);

    public void OnCameraShake(Unit unit, CinemachineVirtualCamera cam);

    public void OnMoveMap();
}

public enum CameraEffectType
{
    Shake,
    Impulse,
    ShockWave,
    None
}