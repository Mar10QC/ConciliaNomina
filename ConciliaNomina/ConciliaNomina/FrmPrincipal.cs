using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace ConciliaNomina
{
    public partial class FrmPrincipal : Form
    {
        private NameValueCollection appSettings = ConfigurationManager.AppSettings;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public List<string> LstDirArchivos(string dir)
        {
            List<string> archivos = new List<string>();
            try
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    //Validar que el archivo tenga la extensión ".xls"
                    if (f.EndsWith(".xls") || f.EndsWith(".XLS")) { archivos.Add(f); }
                }
                foreach (string d in Directory.GetDirectories(dir))
                {
                    archivos.AddRange(LstDirArchivos(d));
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("LstDirArchivos" + Environment.NewLine + ex.Message);
            }
            return archivos;
        }
        private void BtGenerarRpts_Click(object sender, EventArgs e)
        {
            BtGenerarRpts.Enabled = false;
            if (string.IsNullOrEmpty(TbDirIDSE.Text) | string.IsNullOrEmpty(TbDirSUA.Text) | string.IsNullOrEmpty(TbDirRpts.Text))
            {
                MessageBox.Show("Por favor ingrese la información requerida en todos los campos.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(TbDirIDSE.Text) | !Directory.Exists(TbDirSUA.Text) | !Directory.Exists(TbDirRpts.Text))
            {
                MessageBox.Show("Una de las direcciones especificadas no existe o no es una ruta valida." +
                                "\nPor favor verifique la información", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var lstDirArchivos = LstDirArchivos(TbDirIDSE.Text);
                //ProcesarIDSE idse = new ProcesarIDSE();
                //foreach (var dirArchivo in lstDirArchivos)
                //{
                //    idse.ProcesarArchivo(dirArchivo);
                //}
                //lstDirArchivos = LstDirArchivos(TbDirSUA.Text);
                //ProcesarSUA sua = new ProcesarSUA();
                //foreach (var dirArchivo in lstDirArchivos)
                //{
                //    sua.ProcesarArchivo(dirArchivo);
                //}
                //RptIdseSuaTressEBA oReporteIdseSuaTressEba = new RptIdseSuaTressEBA(idse.lstCIdseEba, idse.lstDIdseEba, sua.lstCSuaEba, sua.lstDSuaEba, TbDirRpts.Text);
                //oReporteIdseSuaTressEba.ReporteEba();
                //RptIdseSuaTressEMA oReporteIdseSuaTressEma = new RptIdseSuaTressEMA(idse.lstCIdseEma, idse.lstDIdseEma, sua.lstCSuaEma, sua.lstDSuaEma, TbDirRpts.Text);
                //oReporteIdseSuaTressEma.ReporteEma();

                MessageBox.Show("Reportes generados con éxito.", "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbDirIDSE.Clear();
                TbDirSUA.Clear();
                TbDirRpts.Clear();
                BtGenerarRpts.Enabled = true;
            }
        }
        private void TbDirIDSE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbDirIDSE.Text))
                TbDirIDSE.SelectAll();
        }
        private void TbDirSUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbDirSUA.Text))
                TbDirSUA.SelectAll();
        }
        private void TbDirRpts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbDirRpts.Text))
                TbDirRpts.SelectAll();
        }
    }
}
