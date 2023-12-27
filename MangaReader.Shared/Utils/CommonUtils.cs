
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
namespace MangaReader.Shared.Utils;

public static class CommonUtils
{
    public static string StringToMD5(string data)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(data);

            // mã hóa input bytes thành MD5 hash 
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Chuyển hash thành chuỗi hex 
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public static string RandomColor()
    {

        var random = new Random();
        var colorBytes = new byte[3];

        random.NextBytes(colorBytes);
        return String.Format("#{0:X2}{1:X2}{2:X2}",
              colorBytes[0], colorBytes[1], colorBytes[2]);
    }

   
}
