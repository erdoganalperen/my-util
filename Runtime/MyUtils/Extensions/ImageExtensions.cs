using UnityEngine.UI;

namespace Runtime.MyUtils.Extensions
{
    public static class ImageExtensions
    {
        public static void SetAlpha(this Image i, float newAlpha) {
            var color = i.color;
            color.a = newAlpha;
            i.color = color;
        } 
    }
}