using System;

namespace Math
{
    public static class Mathf
    {
        public static float Sigmoid (float value)
        {
            return 1f / (1f + MathF.Pow(MathF.E, -value));
        }
        public static float Sigmoid(float value, float alpha)
        {
            return 1f / (1f + MathF.Pow(MathF.E, alpha * (-value)));
        }

        public static float HyperbolicTangent(float value)
        {
            return (1 - MathF.Pow(MathF.E, -value)) / (1 + MathF.Pow(MathF.E, -value));
        }
        public static float HyperbolicTangent(float value, float alpha)
        {
            return (1 - MathF.Pow(MathF.E, alpha * (-value))) / (1 + MathF.Pow(MathF.E, alpha * (-value)));
        }

        public static float HardLimit(float value)
        {
            return (value < 0) ? 0 : 1;
        }
    }
}