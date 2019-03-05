using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using Xamarin.Forms;
using Vagas.iOS.Banco;
using Vagas.Banco;

[assembly: Dependency(typeof(Caminho))]
namespace Vagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhodaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            string caminhoBanco = Path.Combine(caminhodaBiblioteca, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}