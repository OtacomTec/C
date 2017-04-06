using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NFe_Web3G;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ws_nfeEnvia_Lote aut = new Ws_nfeEnvia_Lote();
            
            if (aut.EnviaLote(NFe_Web3G.C_UF.RJ_SVRS, NFe_Web3G.TP_Ambiente.Homologacao, NFe_Web3G.TipoCertificado.A3, "BEQUEMED LTDA ME:01569403000119", "", "CN=BEQUEMED LTDA ME:01569403000119, OU=Autenticado por PRODEMGE, OU=RFB e-CNPJ A1, OU=Secretaria da Receita Federal do Brasil - RFB, L=BARBACENA, S=MG, O=ICP-Brasil, C=BR",  "d:\\PROJETOS\\Sistemas\\Client Logicx\\INTEGRAÇÃO\\NFE\\XML\\292-env-lot.xml", false, "") == false )
            {
                MessageBox.Show (aut.MsgRetorno);
            }


        }
    }
}
