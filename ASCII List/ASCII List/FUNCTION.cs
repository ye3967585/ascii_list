using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_List
{
    public class CONVERT
    {
        /// <summary>
        /// 字符串转换成ASCII代码格式并以字符串的形式再次输出
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToASCII(string value,bool septum=false)
        {
            byte[] arrary = Encoding.ASCII.GetBytes(value);
            string asciiStr=null;
            for (int i = 0; i < arrary.Length; i++)
            {
                int asciiCode = (int)arrary[i];
                asciiStr += Convert.ToString(asciiCode);
                if (septum)
                {
                    asciiStr += " ";
                }
            }
            return asciiStr;
        }
    }
}
