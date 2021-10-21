using System;
using Microsoft.AspNetCore.Mvc.Razor;

namespace MiniLoja.App.Extensions
{
    public static class RazorExtensions
    {
        public static string FormataDocumento(this RazorPage page, int tipoPessoa, string documento)
        {
            return tipoPessoa == 1 ? Convert.ToInt64(documento).ToString(@"000\.000\.000\-00") : Convert.ToInt64(documento).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}