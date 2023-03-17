using System;

namespace PlayerPowers
{
    [Flags]
    public enum Powers
    {
        None = 0,
        Fly = 1 << 0,            // 1
        XRayVision = 1 << 1,     // 2
        SuperStrength = 1 << 2   // 4
    }
}