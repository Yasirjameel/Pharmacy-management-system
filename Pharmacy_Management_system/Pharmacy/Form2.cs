using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Pharmacy_Yasir
{
    public partial class Form2 : Form
    {

        List<Class> _list;
        string _total,/* _cash, _change,*/ _dtae/*_pdisc*/;

        private void p(object sender, ReportPrintEventArgs e)
        {
            // if (e.Control && e.KeyCode.ToString() == "p")
            
            MessageBox.Show("print complete");

        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            //    base.OnKeyDown(e);

            if (e.Control && e.KeyCode.ToString() == "Q")
            {
                MessageBox.Show("print complete");  //        reportViewer1.PrintDialog();
            }
            else
                MessageBox.Show("wrong key");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //base.OnKeyDown(e);

            //if (e.Control&&e.KeyCode==Keys.P)
            //    
        }
        public Form2( List<Class> dataSource, string total,/* string cash, string change,*/ string date/*string pdisc*/ )
        {


            InitializeComponent();
            _list = dataSource;
            _total = total;
         //   _cash = cash;
       //     _change = change;
            _dtae = date;
          //  _pdisc = pdisc;




        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   if (e.Control && e.KeyCode.ToString() == "p")
 //               MessageBox.Show("print complete");
            reportViewer1.PrintDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {




            classBindingSource.DataSource = _list;
            ReportParameter[] para = new ReportParameter[]
                {
                    new ReportParameter("pTotal",_total),
          //          new ReportParameter("pCash",_cash),
         //           new ReportParameter("pChange",_change),
                    new ReportParameter("pDate",_dtae),
              //      new ReportParameter("pdisc",_pdisc),
                };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();


   
         //   Order obj = new Order();
            ReportParameter[] parms = new ReportParameter[7];
            parms[0] = new ReportParameter("pgt", WindowsReporting.Report.l1);
            parms[1] = new ReportParameter("pdisc", WindowsReporting.Report.l2);
            parms[2] = new ReportParameter("pdg", WindowsReporting.Report.l3);
            parms[3] = new ReportParameter("pdi", WindowsReporting.Report.l4);
            parms[4] = new ReportParameter("pdis", WindowsReporting.Report.f1);
            parms[5] = new ReportParameter("pdiss", WindowsReporting.Report.f2);
            parms[6] = new ReportParameter("pdisss", WindowsReporting.Report.f3);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();


  


        }
    }
}
